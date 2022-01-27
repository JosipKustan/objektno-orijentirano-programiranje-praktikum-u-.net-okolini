using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_FootballProject.Views;

namespace WPF_FootballProject.Utils
{
    public static class DialogBoxCaller
    {
        public static void Show(Window owner, String text)
        {
            DialogBox dialogBox = new DialogBox(text);
            dialogBox.Owner = owner;
            dialogBox.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
            dialogBox.ShowDialog();
        }
    }
}
