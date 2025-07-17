using System.Drawing;

namespace Mehrak
{
    partial class frmNewChat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNewText = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pboxMehrakBg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMehrakBg)).BeginInit();
            this.pboxMehrakBg.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNewText
            // 
            this.txtNewText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.txtNewText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewText.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(209)))), ((int)(((byte)(190)))));
            this.txtNewText.Location = new System.Drawing.Point(101, 597);
            this.txtNewText.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewText.Multiline = true;
            this.txtNewText.Name = "txtNewText";
            this.txtNewText.Size = new System.Drawing.Size(707, 46);
            this.txtNewText.TabIndex = 1;
            this.txtNewText.Text = "Text here...";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(92)))));
            this.btnBack.BackgroundImage = global::Mehrak.Properties.Resources.BackButtonImage;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(92)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(829, 593);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 47);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pboxMehrakBg
            // 
            this.pboxMehrakBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxMehrakBg.Controls.Add(this.panel1);
            this.pboxMehrakBg.Location = new System.Drawing.Point(25, 40);
            this.pboxMehrakBg.Name = "pboxMehrakBg";
            this.pboxMehrakBg.Size = new System.Drawing.Size(850, 545);
            this.pboxMehrakBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxMehrakBg.TabIndex = 1;
            this.pboxMehrakBg.TabStop = false;
            this.pboxMehrakBg.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(66, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 483);
            this.panel1.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(92)))));
            this.btnSave.BackgroundImage = global::Mehrak.Properties.Resources.bookmark;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(92)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(25, 593);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(46, 47);
            this.btnSave.TabIndex = 0;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // frmNewChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(209)))), ((int)(((byte)(190)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pboxMehrakBg);
            this.Controls.Add(this.txtNewText);
            this.Controls.Add(this.btnSave);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNewChat";
            this.Text = "NewChat";
            ((System.ComponentModel.ISupportInitialize)(this.pboxMehrakBg)).EndInit();
            this.pboxMehrakBg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNewText;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pboxMehrakBg;
        private System.Windows.Forms.Panel panel1;
    }
}