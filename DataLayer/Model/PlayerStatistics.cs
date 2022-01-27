using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProject.Models
{
    public class PlayerStatistics 
    {
        private const string DEFAULT_PICTURE= "Images\\default.jpg";
        public Player Player { get; set; }
        public int YellowCards { get; set; }
        public int Goals { get; set; }

        public PlayerStatistics()
        {
        }
        public PlayerStatistics(Player player, int yellowCards, int goals)
        {
            Player = player;
            YellowCards = yellowCards;
            Goals = goals;

            SetDefaultPicture();
        }

        private void SetDefaultPicture()
        {
            if (Player.PicturePath is null)
            {
                Player.PicturePath = Path.GetFullPath(DEFAULT_PICTURE);
            }
        }
    }
}
