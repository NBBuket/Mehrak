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
        public static Panel PanelTop;
        public static Button CloseButton;
        public static Button MinimizeButton;
        private bool dragging = false;
        private Point dragStartPoint;
        public MainForm()
        {
            InitializeComponent();
            MainPanel = mainPanel;
            PanelTop = pnlTop;
            CloseButton = btnClose;
            MinimizeButton = btnMinimize;
        }
        
        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            frmMainMenu form1 = new frmMainMenu();
            Mehrak.ShowFormsOnPanel.OpenFormInMain(form1);

        }
        #region TopPanel Movement
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragStartPoint = e.Location;
            }
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Location = new Point(this.Location.X + (e.X - dragStartPoint.X),
                                          this.Location.Y + (e.Y - dragStartPoint.Y));
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
