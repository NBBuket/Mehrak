using Mehrak.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mehrak
{
    public partial class frmNewChat : Form
    {
        private Image backgroundImage;
        private bool isSumeru = false;
        private string Sumerulu = string.Empty;
        List<string> SumeruluList = new List<string> { "Alhaitham", "Candace", "Collei", "Cyno", "Dehya", "Dori", 
            "Faruzan", "Kaveh", "Layla","Nahida", "Nilou", "Sethos", "Nari", "Tighnari", "Haitham", "Zhongli", 
            "Morax", "Paimon", "Hilichrul" };

        public frmNewChat()
        {
            backgroundImage = global::Mehrak.Properties.Resources.mehrakBackground;
            MainForm.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(197)))), ((int)(((byte)(165)))));
            MainForm.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(209)))), ((int)(((byte)(190)))));
            MainForm.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(197)))), ((int)(((byte)(165)))));
            MainForm.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            MainForm.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            InitializeComponent();
            txtNewText.KeyDown += textBox_KeyDown;
        }

        #region Toolbox Events

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            List<string> allTexts = new List<string>();

            foreach (Control control in panel1.Controls)
            {
                if (control is UserControl userControl)
                {
                    foreach (Control subControl in userControl.Controls)
                    {
                        if (subControl is Panel panel)
                        {
                            foreach (Control panelControl in panel.Controls)
                            {
                                if (panelControl is System.Windows.Forms.TextBox textBox)
                                {
                                    allTexts.Add(textBox.Text);
                                }
                            }
                        }
                    }
                }
            }
            allTexts.Reverse();
            for (int i = 0; i < allTexts.Count; i++)
            {
                string prefix = (i + 1) % 2 == 1 ? "-" : "+";
                allTexts[i] = $"{prefix} {allTexts[i]}";
            }
            SaveTextsToFile(allTexts);
        }

        private void SaveTextsToFile(List<string> texts)
        {
            try
            {
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string folderName = "Chats With Mehrak";
                string fullFolderPath = Path.Combine(documentsPath, folderName);

                if (!Directory.Exists(fullFolderPath))
                {
                    Directory.CreateDirectory(fullFolderPath);
                }

                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Text files (*.txt)|*.txt";
                    saveDialog.DefaultExt = "txt";
                    saveDialog.InitialDirectory = fullFolderPath;

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllLines(saveDialog.FileName, texts);
                        MessageBox.Show("File saved successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}");
            }
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            ColorMatrix colorMatrix = new ColorMatrix();
            colorMatrix.Matrix33 = 0.4f; // 40% opacity

            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix);

            e.Graphics.DrawImage(backgroundImage,
                               new Rectangle(0, 0, pboxMehrakBg.Width, pboxMehrakBg.Height),
                               0, 0, backgroundImage.Width, backgroundImage.Height,
                               GraphicsUnit.Pixel, imageAttributes);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu form1 = new frmMainMenu();
            Mehrak.ShowFormsOnPanel.OpenFormInMain(form1);
        }
        #endregion

        #region UserControl
        public void AddMessage(IChatModel message)
        {
            if (isSumeru)
            {
                var chatItem1 = new ChatItem(message, true, Sumerulu);
                chatItem1.Name = "chatItem" + panel1.Controls.Count;
                chatItem1.Dock = DockStyle.Top;
                panel1.Controls.Add(chatItem1);
                chatItem1.BringToFront();

                chatItem1.ResizeBubbles((int)(panel1.Width * 0.6));

                panel1.ScrollControlIntoView(chatItem1);
            }
            else
            {
                var chatItem = new ChatItem(message, false, "");
                chatItem.Name = "chatItem" + panel1.Controls.Count;
                chatItem.Dock = DockStyle.Top;
                panel1.Controls.Add(chatItem);
                chatItem.BringToFront();
                chatItem.ResizeBubbles((int)(panel1.Width * 0.6));
                panel1.ScrollControlIntoView(chatItem);
            }
            if (message != null)
            {
                AddMessage(null);
                isSumeru = false;
            }

        }

        async void SendMessage()
        {
            string chatmessage = txtNewText.Text;
            if (hasSumeruNames(chatmessage))
            {
                isSumeru = true;
            }
            IChatModel chatModel = null;
            TextChatModel textModel = null;

            if (!string.IsNullOrWhiteSpace(chatmessage))
            {
                textModel = new TextChatModel()
                {
                    Body = chatmessage,
                    Inbound = false,
                    Read = true,
                    Time = DateTime.Now
                };
            }

            try
            {
                if (chatModel != null)
                {
                    AddMessage(chatModel);
                }
                else if (textModel != null)
                {
                    AddMessage(textModel);
                    txtNewText.Text = string.Empty;
                }
            }
            catch (Exception exc)
            {
                textModel = new TextChatModel()
                {
                    Author = "Ganbu",
                    Body = "The message could not be processed. Please see the reason below.\r\n" + exc.Message,
                    Inbound = false,
                    Read = true,
                    Time = DateTime.Now
                };
                AddMessage(textModel);
            }
        }

        private bool hasSumeruNames(string text)
        {
            string firstFound = SumeruluList.FirstOrDefault(item =>
               text.ToLower().Contains(item.ToLower()));
           
            if(firstFound != null)
            {
                Random random = new Random();
                bool choice = random.Next(2) == 0;
                if (choice)
                {
                    firstFound = firstFound.ToUpper();
                }
                Sumerulu = firstFound;
                return true;
            }else
                return false;
        }
        
        #endregion
    }
}
