using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehrak.UserControls
{
    public partial class ChatItem : UserControl
    {
        public IChatModel ChatModel { get; set; }
        public ChatItem()
        {
            InitializeComponent();
        }

        public ChatItem(IChatModel chatModel, bool isSumeru)
        {
            InitializeComponent();

            if (chatModel == null)
            {
                if (isSumeru)
                {
                    chatModel = new ImageChatModel()
                    {
                        Author = "Mehrak",
                        Image = MehraksStickers("Cyno"),
                        ImageName = "Sticker",
                        Inbound = true,
                        Read = true,
                        Time = DateTime.Now,
                    };
                }
                else
                    chatModel = new TextChatModel()
                    {
                        Author = "Mehrak",
                        Body = WhatMehrakSaid(),
                        Inbound = true,
                        Time = DateTime.Now
                    };
            }
           
                ChatModel = chatModel;

            if (chatModel.Inbound) //Mehrakın cevapları
            {
                bodyPanel.Dock = DockStyle.Left;
                authorLabel.Dock = DockStyle.Left;
                bodyPanel.BackColor = Color.FromArgb(167, 252, 92);
                bodyTextBox.BackColor = Color.FromArgb(167, 252, 92);
                bodyTextBox.ForeColor = Color.FromArgb(152, 135, 64);
            }
            else //Ganbunun mesajları
            {
                bodyPanel.Dock = DockStyle.Right;
                authorLabel.Dock = DockStyle.Right;
                bodyTextBox.TextAlign = HorizontalAlignment.Right;
                bodyPanel.BackColor = Color.FromArgb(12, 85, 0);
                bodyTextBox.BackColor = Color.FromArgb(12, 85, 0);
                bodyTextBox.ForeColor = Color.FromArgb(214, 204, 125);
            }

            authorLabel.Text = $"{chatModel.Author ?? "Ganbu"}, {chatModel.Time.ToShortTimeString()}";

            switch (chatModel.Type)
            {
                case "text":
                    var textmodel = chatModel as TextChatModel;
                    bodyTextBox.Text = textmodel.Body.Trim();
                    break;
                case "image":
                    var imagemodel = chatModel as ImageChatModel;
                    bodyTextBox.Visible = false;
                    bodyPanel.BackgroundImage = imagemodel.Image;
                    bodyPanel.BackColor = Color.GhostWhite;
                    bodyPanel.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// buraya istediğin kadar text eklemesi yapabilirsin
        /// </summary>
        /// <returns></returns>
        public string WhatMehrakSaid()
        {
            Dictionary<int, string> beeps = new Dictionary<int, string>();
            beeps.Add(0, "beep... boop...");
            beeps.Add(1, "beep");
            beeps.Add(2, "boop");
            beeps.Add(3, "beep boop!");
            beeps.Add(4, "beep boop...");
            beeps.Add(5, "beep beep");
            beeps.Add(6, "boop beep boob");
            beeps.Add(7, "boop boop");
            beeps.Add(8, "...");
            Random Random = new Random();
            return beeps[Random.Next(9)];
        }

        public Image MehraksStickers(string charName)
        {
            Dictionary<string, Image> boops = new Dictionary<string, Image>();
            boops.Add("Kaveh", global::Mehrak.Properties.Resources.mehrakBackground);
            boops.Add("Cyno", global::Mehrak.Properties.Resources.BackButtonImage);
            boops.Add("Nari", global::Mehrak.Properties.Resources.bookmark);
            if(charName == "Kaveh")
            {
                return boops["Kaveh"];
            } 
            else if(charName == "Cyno")
            {
                return boops["Cyno"];
            }
            else
            {
                return boops["Nari"];
            }
        }

        /// <summary>
        /// Buralara hiç dokunmayalım olduğu gibi aldım kodu valla ve çok da anlamaya uğraşmadım, anladıysan sen yazarsın<3
        /// </summary>
        /// <param name="maxwidth"></param>

        public void ResizeBubbles(int maxwidth)
        {
            if (ChatModel == null)
            {
                return;
            }
            else
            {
                SuspendLayout();

                switch (ChatModel.Type)
                {
                    case "image":
                        var imagemodel = ChatModel as ImageChatModel;
                        if (imagemodel.Image.Width < maxwidth + (Width - bodyPanel.Width))
                        {
                            
                            bodyPanel.Width = imagemodel.Image.Width;

                            Height = imagemodel.Image.Height + (Height - bodyPanel.Height);
                        }
                        else
                        {
                            double ratio = (double)maxwidth / (double)imagemodel.Image.Width;
                            int adjheight = (int)(imagemodel.Image.Height * ratio);

                            bodyPanel.Width = maxwidth;
                            Height = adjheight + (Height - bodyPanel.Height);
                        }
                        break;
                    case "text":
                        var textmodel = ChatModel as TextChatModel;
                        string body = textmodel.Body;
                        TextChange(bodyTextBox.Text);
                        break;
                    default:
                        break;
                }
            }

            ResumeLayout();

            void TextChange(string body)
            {
                int fontheight = bodyTextBox.Font.Height;
                var gfx = this.CreateGraphics();
                int lines = 1;
                double stringwidth = gfx.MeasureString(body, bodyTextBox.Font).Width;

                //The system is as follows. The box width can only go to MaxWidth, if it goes to MaxWidth, then wordwrap will bring the text down to a new line.
                //In order to fit it, we'll need to adjust the height by a certain amount of units.
                if (stringwidth < maxwidth + bodyPanel.Width - bodyTextBox.Width)
                {
                    //This is great, we can set the width to be a small as the actual text.
                    bodyPanel.Width = (int)(stringwidth + bodyPanel.Width - bodyTextBox.Width + 5);
                }
                else
                {
                    lines = 0;
                    bodyPanel.Width = maxwidth + bodyPanel.Width - bodyTextBox.Width;
                    string noescapebody = body.Replace("\r\n", string.Empty).Replace("\r\n", string.Empty);
                    stringwidth = gfx.MeasureString(noescapebody, bodyTextBox.Font).Width;

                    while (stringwidth > 0)
                    {
                        stringwidth -= bodyPanel.Width;
                        lines++;
                    }
                }
                if (body.Contains("\n"))
                {
                    while (body.Contains("\r\n"))
                    {
                        body = body.Remove(body.IndexOf("\r\n"), "\r\n".Length);
                        lines++;
                    }
                    while (body.Contains("\n"))
                    {
                        body = body.Remove(body.IndexOf("\n"), "\n".Length);
                        lines++;
                    }
                }

                //Adjusts the height based on the number of lines.
                Height = (lines * fontheight) + Height - bodyTextBox.Height;
            }
        }

    }
}
