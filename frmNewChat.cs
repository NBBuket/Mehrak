using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehrak
{
    public partial class frmNewChat : Form
    {
        private Image backgroundImage;
        public frmNewChat()
        {
            backgroundImage = global::Mehrak.Properties.Resources.mehrakBackground;
            MainForm.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(197)))), ((int)(((byte)(165)))));
            MainForm.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(209)))), ((int)(((byte)(190)))));
            MainForm.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(197)))), ((int)(((byte)(165)))));
            MainForm.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            MainForm.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            frmSaveAs saveAs = new frmSaveAs();
            saveAs.ShowDialog();
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

    }
}
