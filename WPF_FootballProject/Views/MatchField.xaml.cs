
using DataLayer.FileIO;
using DataLayer.Model;
using DataLayer.Utils;
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

namespace WPF_FootballProject.Views
{
    /// <summary>
    /// Interaction logic for MatchField.xaml
    /// </summary>
    public partial class MatchField : Window
    {

        private IList<Player> goliePlayersHome = new List<Player>();
        public MatchField(DataLayer.Model.Match dataContext)
        {
            InitializeComponent();
            dataContext.HomeTeamStatistics.StartingEleven = (List<Player>)StoredPlayers.ReplaceWithStoredPlayer(dataContext.HomeTeamStatistics.StartingEleven);
            dataContext.AwayTeamStatistics.StartingEleven = (List<Player>)StoredPlayers.ReplaceWithStoredPlayer(dataContext.AwayTeamStatistics.StartingEleven);
            DataContext = dataContext;
            InitPlayers();
        }

        private void InitPlayers()
        {
            if (DataContext is Match match)
            {
               homeTeamGolie.ItemsSource = match.HomeTeamStatistics.StartingEleven.ToList().Where(player=>player.Position.Equals(Position.Goalie));
               homeTeamDefenders.ItemsSource = match.HomeTeamStatistics.StartingEleven.ToList().Where(player=>player.Position.Equals(Position.Defender));
               homeTeamMids.ItemsSource = match.HomeTeamStatistics.StartingEleven.ToList().Where(player=>player.Position.Equals(Position.Midfield));
               homeTeamForwards.ItemsSource = match.HomeTeamStatistics.StartingEleven.ToList().Where(player=>player.Position.Equals(Position.Forward));

               awayTeamGolie.ItemsSource = match.AwayTeamStatistics.StartingEleven.ToList().Where(player=>player.Position.Equals(Position.Goalie));
               awayTeamDefenders.ItemsSource = match.AwayTeamStatistics.StartingEleven.ToList().Where(player=>player.Position.Equals(Position.Defender));
               awayTeamMids.ItemsSource = match.AwayTeamStatistics.StartingEleven.ToList().Where(player=>player.Position.Equals(Position.Midfield));
               awayTeamForwards.ItemsSource = match.AwayTeamStatistics.StartingEleven.ToList().Where(player=>player.Position.Equals(Position.Forward));
            }
        }

        private void OpenPlayerDetails(object sender, MouseButtonEventArgs e)
        {
            if (sender is StackPanel playerPanel)
            {
                var playerContext = (Player)playerPanel.DataContext;
                PlayerStats playerStats = new PlayerStats(playerContext, (Match)DataContext);
                playerStats.ShowDialog();
                playerStats.Focus();
            }
        }
    }
}
