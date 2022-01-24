using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsProject.Forms;

namespace WindowsFormsProject.Controls
{
    public partial class MatchControl : UserControl
    {
        public Match Match{ get;}
        public MatchControl(Match match)
        {
            Match = match;
            InitializeComponent();
            FillControl();
        }

        private void FillControl()
        {
            lblVenue.Text = Match.Venue;
            lblLocation.Text=Match.Location + " ("+Match.Attendance+")";
            lblHomeTeam.Text = Match.HomeTeam.Country + " (" + Match.HomeTeam.Code + ")";
            lblAwayTeam.Text = Match.AwayTeam.Country + " (" + Match.AwayTeam.Code + ")";
            lblHomeScore.Text = Match.HomeTeam.Goals.ToString();
            lblAwayScore.Text = Match.AwayTeam.Goals.ToString();
            lblHomePenalties.Text=Match.HomeTeam.Penalties.ToString();
            lblAwayPenalties.Text=Match.AwayTeam.Penalties.ToString();

            btnAwayPlayers.Text += " " + Match.AwayTeam.Code;
            btnHomePlayers.Text += " " + Match.HomeTeam.Code;
            

        }

        private void btnHomePlayers_Click(object sender, EventArgs e)
        {
            IList<Player> players = new List<Player>();
            Form playersStatList = new PlayerStats(Match.HomeTeamStatistics.GetAllPlayers(),Match.HomeTeamEvents);
            playersStatList.Show();
        }

        private void btnAwayPlayers_Click(object sender, EventArgs e)
        {
            IList<Player> players = new List<Player>();
            Form playersStatList = new PlayerStats(Match.AwayTeamStatistics.GetAllPlayers(), Match.AwayTeamEvents);
            playersStatList.Show();
        }
    }
}
