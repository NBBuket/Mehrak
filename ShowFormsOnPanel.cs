using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehrak
{
    internal static class ShowFormsOnPanel
    {
        internal static void OpenFormInMain(Form form1)
        {
            form1.Dock = DockStyle.Fill;
            form1.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form1);
            form1.Show();
        }
    }
}
