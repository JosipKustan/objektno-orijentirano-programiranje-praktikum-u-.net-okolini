using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WindowsFormsProject.Models;
using WPF_FootballProject.Utils;
using static WindowsFormsProject.Models.AppSettings;

namespace WPF_FootballProject.Views
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public League SelectedLeague { get; set; }
        public Language SelectedLanguage { get; set; }
        public Settings()
        {
            InitializeComponent();
            GetSavedSettings();
        }

        private void GetSavedSettings()
        {
            try
            {
                AppSettings savedAppSettings = AppSettings.GetSavedAppSettings();
                if (savedAppSettings.SavedLeague == League.Man)
                {
                    rbMan.IsChecked = true;
                }
                else
                {
                    rbWoman.IsChecked = true;
                }
                if (savedAppSettings.SavedLanguage == AppSettings.Language.English)
                {
                    rbEnglish.IsChecked = true;
                }
                else
                {
                    rbCroatian.IsChecked = true;
                }
            }
            catch (Exception)
            {
                new Thread(() => {
                    Thread.Sleep(300);
                    DialogBoxCaller.Show(this, "No saved files");

                }).Start();


            }
        }

        private void Save_And_Continue_Click(object sender, RoutedEventArgs e)
        {
            
            SelectedLanguage = (bool)rbEnglish.IsChecked ? AppSettings.Language.English : AppSettings.Language.Croatian;

            SelectedLeague = (bool)rbMan.IsChecked ? League.Man: League.Woman;

            SaveSettings(SelectedLeague, SelectedLanguage);
            this.Close();
        }
        private void SaveSettings(League currentLeague, Language currentLanguage)
        {
            AppSettings checkedAppSettings = new AppSettings(currentLeague, currentLanguage);

            try
            {
                AppSettings.SaveSettings(checkedAppSettings);
                DialogBoxCaller.Show(this ,"Settings saved");
            }
            catch (Exception)
            {
                DialogBoxCaller.Show(this, "Could not save settings");
            }
            UpdateSettingsForLaunch();
        }
        private void UpdateSettingsForLaunch()
        {
            App.SavedLanguage = SelectedLanguage;
            App.SavedLeague = SelectedLeague;
        }

    }
}
