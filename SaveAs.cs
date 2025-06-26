using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehrak
{
    public partial class SaveAs : Form
    {
        public SaveAs()
        {
            InitializeComponent();
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
