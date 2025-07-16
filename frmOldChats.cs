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
    public partial class frmOldChats : Form
    {
        public frmOldChats()
        {
            InitializeComponent();
            MainForm.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(209)))), ((int)(((byte)(190)))));
            MainForm.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            MainForm.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(209)))), ((int)(((byte)(190)))));
            MainForm.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            MainForm.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu form1 = new frmMainMenu();
            Mehrak.ShowFormsOnPanel.OpenFormInMain(form1);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
