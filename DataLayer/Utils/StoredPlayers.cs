using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Utils
{
    public static class StoredPlayers
    {
        public static IList<Player> storedPlayers = new List<Player>();
        public static IList<Player> ReplaceWithStoredPlayer(IList<Player> players)
        {
            IList<Player> playersTemp = players;

            if (storedPlayers != null)
            {

                foreach (Player storedPlayer in storedPlayers)
                {
                    int index = playersTemp.ToList().FindIndex(player => player.Equals(storedPlayer));

                    if (index > -1)
                    {
                        playersTemp[index] = storedPlayer;
                    }

                }
            }
            return playersTemp;
        }

    }
}
