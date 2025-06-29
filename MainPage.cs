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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void newChat_Click(object sender, EventArgs e)
        {
            NewChat newChat = new NewChat();
            newChat.Dock = DockStyle.Fill;
            newChat.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(newChat);
            newChat.Show();
        }

        private void minWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void oldChat_Click(object sender, EventArgs e)
        {
            OldChat oldChat = new OldChat();
            oldChat.Dock = DockStyle.Fill;
            oldChat.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(oldChat);
            oldChat.Show();
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
