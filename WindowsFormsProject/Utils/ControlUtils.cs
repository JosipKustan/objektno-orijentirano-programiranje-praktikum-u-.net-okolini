using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject.Utils
{
    public class ControlUtils
    {
        public static RadioButton GetCheckedRadioButton(GroupBox buttonGroup)
        {
            return buttonGroup.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
        }
    }
}
