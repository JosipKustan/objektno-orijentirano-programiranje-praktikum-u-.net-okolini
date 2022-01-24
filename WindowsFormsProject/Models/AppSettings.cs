using DataLayer.FileIO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsProject.Models
{
    public class AppSettings
    {
        public static string BASE_DIR = Path.GetTempPath();

        private const string SETTINGS_DIR = "Settings.json";
        private static string FULL_PATH = String.Concat(BASE_DIR, SETTINGS_DIR);
        public Settings.League SavedLeague { get; set; }
        public Settings.Language SavedLanguage { get; set; }

        public AppSettings(Settings.League savedLeague, Settings.Language savedLanguage)
        {
            SavedLeague = savedLeague;
            SavedLanguage = savedLanguage;
        }

        public String SerializeSettings() => JsonConvert.SerializeObject(this);
        public static AppSettings GetSavedAppSettings() 
        {
            return FileIO.FetchObjectFromJsonFile<AppSettings>(FULL_PATH);
        }
        public static void SaveSettings(AppSettings appSettings) 
        {
            
            if (!File.Exists(FULL_PATH))
            {
                File.Create(FULL_PATH);
            }
            FileIO.WriteJsonToFile(FULL_PATH, appSettings.SerializeSettings());
            
        }
    }
}
