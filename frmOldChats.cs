using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehrak
{
    public partial class frmOldChats : Form
    {
        public static string AppDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string FolderPath;
        public frmOldChats()
        {
            InitializeComponent();
            MainForm.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(209)))), ((int)(((byte)(190)))));
            MainForm.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            MainForm.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(209)))), ((int)(((byte)(190)))));
            MainForm.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            MainForm.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            FolderPath = Path.Combine(AppDirectory, "Chats With Mehrak");
            if (!Directory.Exists(FolderPath))
                Directory.CreateDirectory(FolderPath);
        }

        private void LoadFilesToListBox()
        {
            string[] files = Directory.GetFiles(FolderPath, "*.txt");
            listBox1.Items.Clear();
            foreach (var file in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                listBox1.Items.Add(Path.GetFileName(fileName));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu form1 = new frmMainMenu();
            Mehrak.ShowFormsOnPanel.OpenFormInMain(form1);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedTitle = listBox1.SelectedItem.ToString();
                string filePath = Path.Combine(FolderPath, selectedTitle + ".txt");
                frmShowChats show = new frmShowChats(filePath);
                show.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedTitle = listBox1.SelectedItem.ToString();
                string filePath = Path.Combine(FolderPath, selectedTitle + ".txt");
                string fileContent = File.ReadAllText(filePath);
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Deleting now", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    File.Delete(filePath);
                    LoadFilesToListBox();
                }
            }

        }

        private void frmOldChats_Load(object sender, EventArgs e)
        {
            LoadFilesToListBox();
        }
    }
}
