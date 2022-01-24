using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF_FootballProject.Views;

namespace WPF_FootballProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void StartApp(object sender, StartupEventArgs e)
        {
            InitSettings();
        }

        private void InitSettings()
        {
            Settings settingsWindow = new Settings();
            settingsWindow.ShowDialog();

            MainWindow window = new MainWindow();
            window.ShowDialog();
        }
    }

}
