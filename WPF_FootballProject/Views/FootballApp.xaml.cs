using DataLayer.Constants;
using DataLayer.FileIO;
using DataLayer.Model;
using DataLayer.REST;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_FootballProject.Utils;
using static WindowsFormsProject.Models.AppSettings;

namespace WPF_FootballProject.Views
{
    /// <summary>
    /// Interaction logic for FootballApp.xaml
    /// </summary>
    public partial class FootballApp : Window
    {
        
        ObservableCollection<TeamInfo> observedTeams=new ObservableCollection<TeamInfo>();
        ObservableCollection<Match> observedMatches=new ObservableCollection<Match>();
        IList<TeamInfo> teams = new List<TeamInfo>();
        IList<Match> teamMatches = new List<Match>();

        private League League { get; set; }
        private String URL_BASE { get; set; }
        private String FILE_BASE { get; set; }

        public FootballApp()
        {
            InitializeComponent();
        }


        private void InitProps(object sender, RoutedEventArgs e)
        {
            SetLeagueProps();
            GetSelectedTeam();
            GetTeams();
            FileIO.GetStoredPlayers(FILE_BASE);
            
        }

        private async void GetTeams()
        {
            try
            {
                (await HttpFetch.FetchDataFromUrlAsync<IList<TeamInfo>>(URL_BASE + UrlConstants.TEAM_RESULTS)).ToList().ForEach(team=> observedTeams.Add(team));
            }
            catch (Exception)
            {
                DialogBoxCaller.Show(this ,"Failed to Fetch from URL, trying to fetch from stored File");
                try
                {
                    teams = await FileIO.FetchJsonFromFileAsync<IList<TeamInfo>>(FILE_BASE + UrlConstants.TEAM_RESULTS_FILE);
                }
                catch (Exception)
                {

                    DialogBoxCaller.Show(this ,"Failed to Fetch from stored file");
                }
            }

            //TODO

            
            cbTeamSelection.ItemsSource = observedTeams;
            

            SelectSavedTeam();
        }

        private void SelectSavedTeam()
        {
            
            if (DataContext != null)
            {
                cbTeamSelection.SelectedIndex = cbTeamSelection.Items.IndexOf((TeamInfo)DataContext);
            }
            else
            {
                if (cbTeamSelection.Items.Count > 0)
                {
                    cbTeamSelection.SelectedIndex = 0;
                }
            }
        }


        private void SetLeagueProps()
        {
            League = App.SavedLeague;

            if (League == League.Man)
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

        private void GetSelectedTeam()
        {
            try
            {
                DataContext = FileIO.FetchObjectFromJsonFile<TeamInfo>(BASE_DIR + FILE_BASE + UrlConstants.STORED_TEAM);
            }
            catch (Exception)
            {
            }
        }
        

        private void GetMatchAndDetails(object sender, SelectionChangedEventArgs e)
        {
            DataContext = (TeamInfo)e.AddedItems[0];
            observedMatches.Clear();
            SetMatchList(e.AddedItems[0]);
        }

        private async void SetMatchList(object team)
        {
            
            if (team is TeamInfo teamInfo)
            {
                
                (await GetMatchesAsync(teamInfo.FifaCode)).ToList().ForEach(match=>observedMatches.Add(match));

                matchItemControl.ItemsSource = observedMatches;

                //foreach (Match match in matches)
                //{
                //    //DrawMatch(match);
                //}
            }
        }
        //OLD WAY. FUJ 
        //private void DrawMatch(Match match)
        //{
        //    WrapPanelMatches
        //}

        public async Task<IList<Match>> GetMatchesAsync(String fifaCode)
        {
            IList<Match> matches = new List<Match>();
            try
            {
                matches = await HttpFetch.GetMatchesFromHTTPAsync(fifaCode, URL_BASE);
            }
            catch (Exception)
            {
                DialogBoxCaller.Show(this ,"Failed to Fetch from URL, trying to fetch from stored File");
                try
                {
                    matches = await FileIO.GetMatchesFromFileAsync(fifaCode, FILE_BASE);
                }
                catch (Exception)
                {

                    DialogBoxCaller.Show(this ,"Failed to Fetch from stored file");
                }
            }
            return matches;

        }

        private void OpenTeamDetails(object sender, MouseButtonEventArgs e)
        {
            if (sender is Label label)
            {
                TeamInfo teamInfo = FindTeamByName(label.Content.ToString());
                if (teamInfo != null)
                {
                    DataContext = teamInfo;
                }
            }
        }


        private TeamInfo FindTeamByName(string countryName)
        {
            return observedTeams.First(team=>team.Country.Equals(countryName));
        }

        private void OpenMatch(object sender, MouseButtonEventArgs e)
        {
            if (sender is Card card)
            {
               var dataContext = (Match)card.DataContext;
               MatchField matchField = new MatchField(dataContext);
               matchField.ShowDialog();
               matchField.Focus();
            }
        }
    }
}
