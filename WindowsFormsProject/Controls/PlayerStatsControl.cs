using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject.Controls
{
    public partial class PlayerStatsControl : UserControl
    {
        public PlayerStatsControl(int goals, int yellowCards)
        {
            InitializeComponent();
            lbGoals.Text = goals.ToString();
            lbYellowCards.Text = yellowCards.ToString();
        }
    }
}
