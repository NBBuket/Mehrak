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
    public partial class MainForm : Form
    {
        public static Panel MainPanel;
        public MainForm()
        {
            InitializeComponent();
            MainPanel = mainPanel;
        }
        
        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Dock = DockStyle.Fill;
            mainPage.TopLevel = false;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(mainPage);
            mainPage.Show();

        }
    }
}
