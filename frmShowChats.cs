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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mehrak
{
    public partial class frmShowChats : Form
    {
        private System.Drawing.Image backgroundImage;
        private bool isSumeru = false;
        private bool dragging = false;
        private Point dragStartPoint;
        private string FilePath;
        private string Sumerulu = string.Empty;
        List<string> SumeruluList = new List<string> { "Alhaitham", "Candace", "Collei", "Cyno", "Dehya", "Dori",
            "Faruzan", "Kaveh", "Layla","Nahida", "Nilou", "Sethos", "Nari", "Tighnari", "Haitham", "Zhongli",
            "Morax", "Paimon", "Hilichrul" };
        public frmShowChats(string filePath)
        {
            backgroundImage = global::Mehrak.Properties.Resources.mehrakBackground;
            InitializeComponent();
            FilePath = filePath;
            string fileName = Path.GetFileName(filePath);
            lblChatName.Text = fileName.Substring(0, fileName.Length - 4);
        }

        #region Toolbox Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
        private void frmShowChats_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(FilePath);
            CreateSeparateLists(lines);
        }
        #endregion

        #region UserControl
        public void AddMessage(IChatModel message, bool isMehrak)
        {
            if (isSumeru)
            {
                var chatItem1 = new ChatItem(message, true, Sumerulu, isMehrak);
                chatItem1.Name = "chatItem" + panel1.Controls.Count;
                chatItem1.Dock = DockStyle.Top;
                panel1.Controls.Add(chatItem1);
                chatItem1.BringToFront();

                chatItem1.ResizeBubbles((int)(panel1.Width * 0.6));

                panel1.ScrollControlIntoView(chatItem1);
            }
            else
            {
                var chatItem = new ChatItem(message, false, "", isMehrak);
                chatItem.Name = "chatItem" + panel1.Controls.Count;
                chatItem.Dock = DockStyle.Top;
                panel1.Controls.Add(chatItem);
                chatItem.BringToFront();
                chatItem.ResizeBubbles((int)(panel1.Width * 0.6));
                panel1.ScrollControlIntoView(chatItem);
            }
            if (message != null && isSumeru == true && isMehrak)
            {
                isSumeru = false;
            }

        }

        async void SendMessage(string message, bool isMehrak)
        {
            string chatmessage = message;
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
                    AddMessage(chatModel, isMehrak);
                }
                else if (textModel != null)
                {
                    AddMessage(textModel, isMehrak);
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
                AddMessage(textModel, false);
            }
        }

        private bool hasSumeruNames(string text)
        {
            string firstFound = SumeruluList.FirstOrDefault(item =>
               text.ToLower().Contains(item.ToLower()));

            if (firstFound != null)
            {
                Random random = new Random();
                bool choice = random.Next(2) == 0;
                if (choice)
                {
                    firstFound = firstFound.ToUpper();
                }
                Sumerulu = firstFound;
                return true;
            }
            else
                return false;
        }

        private void CreateSeparateLists(string[] lines)
        {
            List<string> GanbusRows = new List<string>();
            List<string> MehraksRows = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                string cleanText = RemovePrefixSymbols(lines[i]);

                if ((i + 1) % 2 == 1)
                {
                    GanbusRows.Add(cleanText);
                }
                else
                {
                    MehraksRows.Add(cleanText);
                }
            }
            int j = 0;
            int k = 0;
            while (j < GanbusRows.Count)
            {
                if ((k + 1) % 2 == 1)
                {
                    SendMessage(GanbusRows[j], false);
                    k = 1;
                }
                else
                {
                    SendMessage(MehraksRows[j], true);
                    k = 0;
                    j++;
                }
            }
            
        }

        private string RemovePrefixSymbols(string text)
        {
            if (text.StartsWith("- ") || text.StartsWith("+ "))
            {
                return text.Substring(2);
            }
            return text;
        }


        #endregion

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

    }
}
