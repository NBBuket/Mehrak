using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace Mehrak.UserControls
{
    public partial class ChatItem : UserControl
    {
        public IChatModel ChatModel { get; set; }
        public static readonly Dictionary<string, Image> Boops = new Dictionary<string, Image>
        {
            {"Alhaitham", global::Mehrak.Properties.Resources.alhaitham_brain},
            {"Haitham", global::Mehrak.Properties.Resources.Alhaitham_overwhelmed},
            {"Candace", global::Mehrak.Properties.Resources.candace_celebration},
            {"CANDACE", global::Mehrak.Properties.Resources.candace_pray},
            {"Collei", global::Mehrak.Properties.Resources.collei_study},
            {"COLLEİ", global::Mehrak.Properties.Resources.collei_yearning},
            {"Cyno", global::Mehrak.Properties.Resources.cyno_fight},
            {"CYNO", global::Mehrak.Properties.Resources.cyno_tcg},
            {"Dehya", global::Mehrak.Properties.Resources.dehya_flowers},
            {"DEHYA", global::Mehrak.Properties.Resources.dehya_confident},
            {"Dori", global::Mehrak.Properties.Resources.dori_evil_smile},
            {"DORİ", global::Mehrak.Properties.Resources.dori_mora},
            {"Faruzan", global::Mehrak.Properties.Resources.faruzan_confident},
            {"FARUZAN", global::Mehrak.Properties.Resources.faruzan_welcome},
            {"Kaveh", global::Mehrak.Properties.Resources.kaveh_inviting},
            {"KAVEH", global::Mehrak.Properties.Resources.kaveh_job_hunting},
            {"Layla", global::Mehrak.Properties.Resources.layla_encouragement},
            {"LAYLA", global::Mehrak.Properties.Resources.layla_sleep_study},
            {"Nahida", global::Mehrak.Properties.Resources.nahida_excited},
            {"NAHİDA", global::Mehrak.Properties.Resources.nahida_wink},
            {"Nilou", global::Mehrak.Properties.Resources.nilou_dancing},
            {"NİLOU", global::Mehrak.Properties.Resources.nilou_princess},
            {"Sethos", global::Mehrak.Properties.Resources.sethos_silly},
            {"SETHOS", global::Mehrak.Properties.Resources.sethos_study},
            {"Nari", global::Mehrak.Properties.Resources.tighnari_flower},
            {"Tighnari", global::Mehrak.Properties.Resources.tighnari_invite},
            {"Hilichurl", global::Mehrak.Properties.Resources.Hilichurls},
            {"kaveh-mehrak", global::Mehrak.Properties.Resources.kaveh_and_mehrak},
            {"Morax", global::Mehrak.Properties.Resources.morax},
            {"Paimon", global::Mehrak.Properties.Resources.paimon_fungi},
            {"Zhongli", global::Mehrak.Properties.Resources.zhongli}
        };

        public static readonly Dictionary<int, string> Beeps = new Dictionary<int, string> {
            {0, "beep... boop..."},
            {1, "beep"},
            {2, "boop"},
            {3, "beep boop!"},
            {4, "beep boop..."},
            {5, "beep beep"},
            {6, "boop beep boob"},
            {7, "boop boop"},
            {8, "..."}
        
        };

        public ChatItem()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creating new chats
        /// </summary>
        /// <param name="chatModel"></param>
        /// <param name="isSumeru"></param>
        /// <param name="charName"></param>
        public ChatItem(IChatModel chatModel, bool isSumeru, string charName)
        {
            InitializeComponent();

            if (chatModel == null)
            {
                if (isSumeru)
                {
                    chatModel = new ImageChatModel()
                    {
                        Author = "Mehrak",
                        Image = MehraksStickers(charName),
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
        /// For showing old chats
        /// </summary>
        /// <param name="chatModel"></param>
        /// <param name="isSumeru"></param>
        /// <param name="charName"></param>
        /// <param name="isMehrak"></param>
        public ChatItem(IChatModel chatModel, bool isSumeru, string charName, bool isMehrak)
        {
            InitializeComponent();

            if (isMehrak)
            {
                if (isSumeru)
                {
                    chatModel = new ImageChatModel()
                    {
                        Author = "Mehrak",
                        Image = MehraksStickers(charName),
                        ImageName = "Sticker",
                        Inbound = true,
                        Read = true,
                        Time = DateTime.Now,
                    };
                }
                chatModel.Inbound = true;
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
        /// Mehraks boops and beeps
        /// </summary>
        /// <returns></returns>
        public string WhatMehrakSaid()
        {
            Random Random = new Random();
            return Beeps[Random.Next(9)];
        }

        public Image MehraksStickers(string charName)
        {
            if (Boops.ContainsKey(charName))
            {
                return Boops[charName];
            }
            else
            {
                return Boops["kaveh-mehrak"];
            }
        }

        /// <summary>
        /// I dont know how this works, DO NOT TOUCH IT WORKS
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
                if (stringwidth < maxwidth + bodyPanel.Width - bodyTextBox.Width)
                {
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
                Height = (lines * fontheight) + Height - bodyTextBox.Height;
            }
        }

    }
}
