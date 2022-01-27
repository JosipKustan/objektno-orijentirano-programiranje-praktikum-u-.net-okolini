using DataLayer.Constants;
using DataLayer.Model;
using DataLayer.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.FileIO
{
    public class FileIO
    {
        public static async Task<T> FetchJsonFromFileAsync<T>(String path)
        {
            var sr = new StreamReader(path);
            var iobuffer = await sr.ReadToEndAsync();
            sr.Close();
            if (!(iobuffer.Length>0))
            {
                throw new Exception("Nothing was read");
            }
            return JsonConvert.DeserializeObject<T>(iobuffer);
        }
        public static T FetchObjectFromJsonFile<T>(String path)
        {
            
            var sr = new StreamReader(path);
            var iobuffer = sr.ReadToEnd();
            sr.Close();
            if (!(iobuffer.Length > 0))
            {
                throw new Exception("Nothing was read");
            }
            return JsonConvert.DeserializeObject<T>(iobuffer);
            
        }

        public static void WriteJsonToFile(String path,String json)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(json);
            sw.Close();

        }

        public static async Task<IList<Match>> GetMatchesFromFileAsync(String fifaCode,String FILE_BASE)
        {
            IList<Match> filteredMatches = new List<Match>();
            try
                {
                    var matches = await FetchJsonFromFileAsync<IList<Match>>(FILE_BASE + UrlConstants.MATCH_FILE);
                //only of that drzava??
                foreach (var match in matches)
                {
                    if (fifaCode.Equals(match.AwayTeam.Code) || fifaCode.Equals(match.HomeTeam.Code))
                    {
                        filteredMatches.Add(match);
                    }
                    
                }
                    return filteredMatches;
                }
                catch (Exception)
                {
                    return null;
                    throw new Exception("Could not fetch from file");
                }
            
        }

        public static IList<Player> GetStoredPlayers(String FILE_BASE)
        {
            String path = FILE_BASE + UrlConstants.STORED_PLAYERS;
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            try
            {
                IList<Player> players = FileIO.FetchObjectFromJsonFile<IList<Player>>(path);
                StoredPlayers.storedPlayers = players != null ? players : new List<Player>();
            }
            catch (Exception)
            {
            }
            return StoredPlayers.storedPlayers;
        }


    }
}
