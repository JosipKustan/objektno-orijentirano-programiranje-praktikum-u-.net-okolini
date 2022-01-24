using DataLayer.Constants;
using DataLayer.FileIO;
using DataLayer.Model;
using DataLayer.REST;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsProject.Controls;

namespace WindowsFormsProject.Forms
{
    public partial class FootballApp : Form
    {
        public static IList<Player> storedPlayers = new List<Player>();
        //VARIABLES
        IList<TeamInfo> teams = new List<TeamInfo>();
        IList<Player> players = new List<Player>();
        IList<Match> teamMatches = new List<Match>();


        //PROPS
        private Settings.League League { get; set; }
        private String URL_BASE { get; set; }
        private String FILE_BASE { get; set; }
        public TeamInfo SelectedTeam { get; set; }


        //CONSTRUCTOR
        public FootballApp(Settings.League currentLeague)
        {
            this.League = currentLeague;
            SetLeagueProps();
            InitializeComponent();
            flowPanelFavorites.AllowDrop = true;
            storedPlayers=GetStoredPlayers();
            btnRankedLists.Visible = false;

        }

        private IList<Player> GetStoredPlayers()
        {
            String path = FILE_BASE + UrlConstants.STORED_PLAYERS;
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            IList<Player> players = FileIO.FetchObjectFromJsonFile<IList<Player>>(path);
            return players!=null?players:storedPlayers;
        }

        private void SetLeagueProps()
        {
            if (League==Settings.League.Man)
            {
                URL_BASE = UrlConstants.MAN_URL_BASE;
                FILE_BASE = UrlConstants.MAN_FILE_BASE;
            }
            else
            {
                URL_BASE = UrlConstants.WOMAN_URL_BASE;
                FILE_BASE = UrlConstants.WOMAN_FILE_BASE;
            }
        }

        //RENDER PRETTIER or kill WinForms
        private void AlphaDown(object sender, PaintEventArgs e)
        {
            if (sender is Panel panel)
            {
                panel.BackColor = ChangeAlpha(panel,144);
                
            }
            if(sender is Label label)
            {
                label.BackColor = ChangeAlpha(label,0);
            }
        }

        private Color ChangeAlpha(Control panel, int alpha)=> Color.FromArgb(alpha, panel.BackColor.R, panel.BackColor.G, panel.BackColor.B);

        private void FootballApp_Load(object sender, EventArgs e)
        {
            btnSelectTeam.Enabled = false;
            GetTeams();
        }

        private void StorePlayers()
        {
            foreach (PlayerControl control in flowPlayerPanel.Controls)
            {
                storedPlayers.Add(control.player);
            }
            foreach (PlayerControl control1 in flowPanelFavorites.Controls)
            {
                storedPlayers.Add(control1.player);
            }
        }

        private async void GetTeams()
        {
            try
            {
                teams = await HttpFetch.FetchDataFromUrlAsync<IList<TeamInfo>>(URL_BASE+UrlConstants.TEAM_RESULTS);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Fetch from URL, trying to fetch from stored File");
                try
                {
                    teams = await FileIO.FetchJsonFromFileAsync<IList<TeamInfo>>(FILE_BASE + UrlConstants.TEAM_RESULTS_FILE);
                }
                catch (Exception)
                {

                    MessageBox.Show("Failed to Fetch from stored file");
                }
            }

            //TODO

            if (teams!=null && teams.Count>0)
            {
                foreach (var team in teams)
                {
                    cbTeamSelection.Items.Add(team);
                }
                if(cbTeamSelection.Items.Count > 0)
                {
                    cbTeamSelection.SelectedIndex = 0;
                }


            }
            btnSelectTeam.Enabled = true;
        }

        private void SelectTeam_Click(object sender, EventArgs e)
        {
            if (flowPanelFavorites.Controls.Count > 0 || flowPlayerPanel.Controls.Count > 0)
            {
                StorePlayers();
            }

            TeamInfo selectedTeam = (TeamInfo)cbTeamSelection.SelectedItem;
           
            SetPlayersAsync(selectedTeam);
            btnRankedLists.Visible = true;

        }

        public async Task<IList<Match>> GetMatchesAsync(String fifaCode)
        {
          
            try
            {
                return await HttpFetch.FetchDataFromUrlAsync<IList<Match>>(URL_BASE + UrlConstants.MATCH_BY_FIFA_CODE + fifaCode);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Fetch from URL, trying to fetch from stored File");
                try
                {
                    return await FileIO.FetchJsonFromFileAsync<IList<Match>>(FILE_BASE + UrlConstants.MATCH_FILE);
                }
                catch (Exception)
                {

                    MessageBox.Show("Failed to Fetch from stored file");
                    return null;
                }
            }


        }
        private async void SetPlayersAsync(TeamInfo team)
        {
            IList<Match> matches = new List<Match>();

            this.SelectedTeam = team;

            matches= await GetMatchesAsync(team.FifaCode);
            

            TeamStatistics teamStatistics= matches.First().HomeTeamStatistics;
            if (team.Country.Equals(teamStatistics.Country))
            {
                try
                {
                    ShowPlayers(teamStatistics);
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not show players");
                }

            }
            else
            {
                teamStatistics = matches.First().AwayTeamStatistics;
                ShowPlayers(teamStatistics);
            }

            teamMatches = matches;
        }

        private void ShowPlayers(TeamStatistics teamStatistics)
        {
            players = teamStatistics.GetAllPlayers();

            players = ReplaceWithStoredPlayer(players);

            flowPlayerPanel.Controls.Clear();
            flowPanelFavorites.Controls.Clear();
            if (players.Count>0)
            {
                foreach (Player player in players)
                {
                    if (player.Favorite)
                    {
                        flowPanelFavorites.Controls.Add(new PlayerControl(player));
                    }
                    else
                    {
                        flowPlayerPanel.Controls.Add(new PlayerControl(player));
                    }
                }
            }
        }

        public static IList<Player> ReplaceWithStoredPlayer(IList<Player> players)
        {
           IList<Player> playersTemp= players;

           if (storedPlayers!=null)
           {

                foreach (Player storedPlayer in storedPlayers)
                {
                    int index = playersTemp.ToList().FindIndex(player=>player.Equals(storedPlayer));

                    if (index > -1)
                    {
                        playersTemp[index] = storedPlayer;
                    }

                }
           }
           return playersTemp;
        }

        private void AcceptData(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PlayerControl)))
            {
                e.Effect=DragDropEffects.Move;

            }
            else
            {
                e.Effect=DragDropEffects.None;
            }
        }

        private void DropData(object sender, DragEventArgs e)
        {
            var controls=flowPlayerPanel.Controls;

            IList<PlayerControl> selectedPlayerControls = new List<PlayerControl>();

            foreach (Control control in controls)
            {
                if (control is PlayerControl playerControl)
                {
                    if (playerControl.IsSelected)
                    {
                        selectedPlayerControls.Add(playerControl);
                    }
                }
            }
            if (selectedPlayerControls.Count>0)
            {
                foreach (var playerControl in selectedPlayerControls)
                {

                    AddPlayerToPanel(playerControl, flowPanelFavorites);
                    playerControl.ToggleSelected();
                    playerControl.SetFavoritePlayer(true);
                }
                return;
            }
            //MessageBox.Show(sender.ToString());
            if ((sender as FlowLayoutPanel).Name.Equals(flowPanelFavorites.Name))
            {
                try
                {
                    PlayerControl playerControl = e.Data.GetData(e.Data.GetFormats()[0]) as PlayerControl;
                    playerControl.SetFavoritePlayer(true);
                    AddPlayerToPanel(playerControl,flowPanelFavorites);
             
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to transfer");
                }
            }
            else
            {
                try
                {
                    PlayerControl playerControl = e.Data.GetData(e.Data.GetFormats()[0]) as PlayerControl;
                    playerControl.SetFavoritePlayer(false);
                    AddPlayerToPanel(playerControl, flowPlayerPanel);

                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to transfer");
                }
            }
        }

        private void AddPlayerToPanel(PlayerControl playerControl, FlowLayoutPanel panel)
        {
            panel.Controls.Add(playerControl);
        }

        private void GetIndexOfControl(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void SavePlayersOnFile(object sender, FormClosingEventArgs e)
        {
            FileIO.WriteJsonToFile(FILE_BASE+UrlConstants.STORED_PLAYERS,JsonConvert.SerializeObject(storedPlayers));
        }

        private void btnRankedLists_Click(object sender, EventArgs e)
        {
            StorePlayers();
            Form rankedList = new RankLists(SelectedTeam,teamMatches);
            rankedList.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                

            });
        }


        private void FootballApp_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to close?", "Infomate", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            SavePlayersOnFile(sender, e);

        }
    }
}
