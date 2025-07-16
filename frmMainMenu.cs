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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            MainForm.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(209)))), ((int)(((byte)(190)))));
            MainForm.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            MainForm.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(209)))), ((int)(((byte)(190)))));
            MainForm.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            MainForm.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
        }

        private void newChat_Click(object sender, EventArgs e)
        {
            frmNewChat newChat = new frmNewChat();
            Mehrak.ShowFormsOnPanel.OpenFormInMain(newChat);
        }

        private void oldChat_Click(object sender, EventArgs e)
        {
            frmOldChats oldChat = new frmOldChats();
            Mehrak.ShowFormsOnPanel.OpenFormInMain(oldChat);
        }
    }
}
