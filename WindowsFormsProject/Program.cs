using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsProject.Forms;

namespace WindowsFormsProject
{
    
    internal static class Program
    {
        private static Settings.Language currentLanguage=Settings.Language.English;
        private static Settings.League currentLeague=Settings.League.Man;
        private static String cultureInfo = "en-UK";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Settings());
            GetLocal();
            Application.Run(new FootballApp(currentLeague));
        }

        private static void GetLocal()
        {
            if (currentLanguage==Settings.Language.Croatian)
            {
                cultureInfo = "hr-HR";
            }
            Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureInfo);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureInfo);
        }

            public static void UpdateLanguage(Settings.Language cultureInfo)
        {
            currentLanguage = cultureInfo;
        } 
        public static void UpdateLeague(Settings.League league)
        {
            currentLeague = league;
        }

        
    }
}
