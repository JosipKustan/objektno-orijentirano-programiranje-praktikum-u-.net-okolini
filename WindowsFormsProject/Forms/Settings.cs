using DataLayer.FileIO;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsProject.Models;
using WindowsFormsProject.Utils;
using static WindowsFormsProject.Models.AppSettings;

namespace WindowsFormsProject
{

    public partial class Settings : Form
    {
        public static string HR_CULTURE_INFO = "hr-HR";
        public static string EN_CULTURE_INFO = "en-EN";

        private static Language currentLanguage;
        private static League currentLeague;

        public static String choosenLanguage;


        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            //See if setting are in file -> load them 

            try
            {
               AppSettings savedAppSettings = AppSettings.GetSavedAppSettings();
                if (savedAppSettings.SavedLeague == League.Man)
                {
                    rbMan.Checked = true;
                }
                else
                {
                    rbWoman.Checked = true;
                }
                if (savedAppSettings.SavedLanguage == Language.English)
                {
                    rbEnglish.Checked = true;
                }
                else
                {
                    rbCroatian.Checked = true;
                }
            }
            catch (Exception)
            {
                new Thread(() => {
                    Thread.Sleep(300);
                    MessageBox.Show("No saved files");
                    
                }).Start();

                
            }

            //if not wait for inputs
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            RadioButton checkedLeague = ControlUtils.GetCheckedRadioButton(bgLeague);
            RadioButton checkedLanguage = ControlUtils.GetCheckedRadioButton(bgLanguage);

            if (checkedLanguage==rbEnglish)
            {
                currentLanguage = Language.English;
            }
            else
            {
                currentLanguage = Language.Croatian;
            }

            if (checkedLeague==rbMan)
            {
                currentLeague=League.Man;
            }
            else
            {
                currentLeague=League.Woman;
            }

            SaveSettings(currentLeague, currentLanguage);

        }

        private void SaveSettings(League currentLeague, Language currentLanguage)
        {
            AppSettings checkedAppSettings = new AppSettings(currentLeague, currentLanguage);

            UpdateSettingsForLaunch();

            try
            {
                AppSettings.SaveSettings(checkedAppSettings);
                MessageBox.Show("Settings saved");
            }
            catch (Exception)
            {
                MessageBox.Show("Could not save settings");
            }
            this.Close();
        }

        private void UpdateSettingsForLaunch()
        {
            Program.UpdateLeague(currentLeague);
            Program.UpdateLanguage(currentLanguage);
        }

        
    }
}
