using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsProject.Forms;
using static WindowsFormsProject.Models.AppSettings;

namespace WindowsFormsProject
{
    
    internal static class Program
    {
        private static Language currentLanguage=Language.English;
        private static League currentLeague=League.Man;
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
            if (currentLanguage==Language.Croatian)
            {
                cultureInfo = "hr-HR";
            }
            Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureInfo);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureInfo);
        }

            public static void UpdateLanguage(Language cultureInfo)
        {
            currentLanguage = cultureInfo;
        } 
        public static void UpdateLeague(League league)
        {
            currentLeague = league;
        }

        
    }
}
