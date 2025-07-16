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
    public partial class frmSaveAs : Form
    {
        public frmSaveAs()
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

        private void okButton_Click(object sender, EventArgs e)
        {
            if (SaveTitle(txtChatName.Text))
            {
                MessageBox.Show("Chat Saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect naming", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            
        }

        private bool SaveTitle(string title)
        {
            if (title.Contains("*") || title.Contains(">") || title.Contains("<")
                || title.Contains("/") || title.Contains("\\") || title.Contains("|")
                || title.Contains("“") || title.Contains("?"))
            {
                return false;
            }
            return true;
        }
    }
}
