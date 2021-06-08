using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci.DATA
{
    public class Metod
    {
        public static void Temizle(Control.ControlCollection kontroller)
        {
            foreach (Control item in kontroller)
            {
                if (item is ComboBox)
                    ((ComboBox)item).SelectedIndex = 0;
                else if (item is TextBox)
                    ((TextBox)item).Clear();
                else if (item is RadioButton)
                    ((RadioButton)item).Checked = true;
                else if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = 1;
                else if (item is CheckBox)
                    ((CheckBox)item).Checked = false;
                else if (item is GroupBox)
                    Temizle(((GroupBox)item).Controls);
                else if (item is FlowLayoutPanel)
                    Temizle(((FlowLayoutPanel)item).Controls);
            }
        }
    }
}
