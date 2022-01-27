using DataLayer.Model;
using System;
using System.Collections.Generic;
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
using WindowsFormsProject.Models;

namespace WPF_FootballProject.Views
{
    /// <summary>
    /// Interaction logic for PlayerStats.xaml
    /// </summary>
    public partial class PlayerStats : Window
    {
        private PlayerStatistics playerStatistics = new PlayerStatistics();
        private Player player = new Player();
        public Match Match { get; set; }
        public int yellowCards;
        public int goals;
        public PlayerStats(DataLayer.Model.Player playerContext, DataLayer.Model.Match matchContext)
        {
            InitializeComponent();
            Match = matchContext;
            player = playerContext;
            AddPlayerEvents();
            DataContext = new PlayerStatistics(player,yellowCards,goals);

        }

        private void AddPlayerEvents()
        {
            var homeMatch = Match.HomeTeamEvents.ToList().Where(e => e.Player.Equals(player.Name));
            var awayMatch = Match.AwayTeamEvents.ToList().Where(e => e.Player.Equals(player.Name));
            if (homeMatch.Count() > 0)
            {
                foreach (var teamEvent in homeMatch)
                {
                    if (teamEvent.TypeOfEvent == TypeOfEvent.Goal || teamEvent.TypeOfEvent == TypeOfEvent.GoalPenalty)
                    {
                        goals += 1;
                    }
                    if (teamEvent.TypeOfEvent == TypeOfEvent.YellowCard)
                    {
                        yellowCards = 1;
                    }
                    if (teamEvent.TypeOfEvent == TypeOfEvent.YellowCardSecond)
                    {
                        yellowCards = 2;
                    }
                }
            }
            if (awayMatch.Count() > 0)
            {
                foreach (var teamEvent in awayMatch)
                {
                    if (teamEvent.TypeOfEvent == TypeOfEvent.Goal || teamEvent.TypeOfEvent == TypeOfEvent.GoalPenalty)
                    {
                        goals += 1;
                    }
                    if (teamEvent.TypeOfEvent == TypeOfEvent.YellowCard)
                    {
                        yellowCards = 1;
                    }
                    if (teamEvent.TypeOfEvent == TypeOfEvent.YellowCardSecond)
                    {
                        yellowCards = 2;
                    }
                }
            }
           
               
        }
    }
}
