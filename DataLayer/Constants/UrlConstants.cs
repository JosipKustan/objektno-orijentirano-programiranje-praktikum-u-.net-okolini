using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Constants
{
    public static class UrlConstants
    {
        public const string MAN_URL_BASE = "https://world-cup-json-2018.herokuapp.com"; 
        public const string WOMAN_URL_BASE = "http://worldcup.sfg.io"; 
        public const string MATCH_BY_FIFA_CODE= "/matches/country?fifa_code="; 
        public const string TEAM_RESULTS= "/teams/results"; 
        

        public const string MAN_FILE_BASE = "JSON files/Man_"; 
        public const string FILE_BASE_DIR = "JSON files"; 
        public const string WOMAN_FILE_BASE = "JSON files/Woman_"; 
        public const string MATCH_FILE= "matches.json"; 
        public const string TEAM_RESULTS_FILE= "results.json"; 
 
        
        public const string STORED_PLAYERS= "storedPlayers.json";
        public const string STORED_TEAM = "storedTeam.json";
        public const string STORED_IMAGES=  "StoredImages"; 



    }
}
