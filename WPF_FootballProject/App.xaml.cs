using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using WPF_FootballProject.Views;
using static WindowsFormsProject.Models.AppSettings;

namespace WPF_FootballProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static String cultureInfo = "en-UK";

        public static League SavedLeague { get; set; }
        public static Language SavedLanguage { get; set; }
        public void StartApp(object sender, StartupEventArgs e)
        {
            InitSettings();
        }

        private void InitSettings()
        {
            Settings settingsWindow = new Settings();
            FootballApp footballApp = new FootballApp();

            
            settingsWindow.ShowDialog();

            GetLocal();

            footballApp.ShowDialog();
        }
        private static void GetLocal()
        {
            if (SavedLanguage == Language.Croatian)
            {
                cultureInfo = "hr-HR";
            }
            Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureInfo);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureInfo);
        }



    }

}
