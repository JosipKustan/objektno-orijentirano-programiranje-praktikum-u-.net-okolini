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
using WindowsFormsProject.Controls;

namespace WindowsFormsProject.Forms
{
    public partial class RankLists : Form
    {
        public List<Match> Matches { get; set; } 
        public TeamInfo SelectedTeam { get; }
        public RankLists(TeamInfo selectedTeam, IList<DataLayer.Model.Match> teamMatches)
        {
            SelectedTeam = selectedTeam;
            Matches = teamMatches.ToList();
            InitializeComponent();
            //MessageBox.Show(SelectedTeam.Country);
            //StringBuilder stringBuilder = new StringBuilder();
            //foreach (var match in Matches)
            //{
            //    stringBuilder.Append(match.Venue+"\n");
            //}
            //MessageBox.Show(stringBuilder.ToString());
            SortMatches();
            InitMatches();
        }

        private void SortMatches()
        {
            Matches.Sort((a, b) => -a.Attendance.CompareTo(b.Attendance));
        }

        private void InitMatches()
        {
            
            foreach (Match match in Matches)
            {
                var matchControl = new MatchControl(match);
                matchControl.Anchor=AnchorStyles.None;
                flowPanelMatches.Controls.Add(matchControl);
            }
        }
    }
}
