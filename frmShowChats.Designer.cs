using System.Drawing;

namespace Mehrak
{
    partial class frmShowChats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowChats));
            this.pboxMehrakBg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblChatName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMehrakBg)).BeginInit();
            this.pboxMehrakBg.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
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
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(900, 40);
            this.pnlTop.TabIndex = 9;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(197)))), ((int)(((byte)(165)))));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            this.btnMinimize.Location = new System.Drawing.Point(767, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 25);
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.Text = "⎯";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(197)))), ((int)(((byte)(165)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            this.btnClose.Location = new System.Drawing.Point(825, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 25);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblChatName
            // 
            this.lblChatName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChatName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.lblChatName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblChatName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblChatName.Font = new System.Drawing.Font("Times New Roman", 25.25F);
            this.lblChatName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(209)))), ((int)(((byte)(190)))));
            this.lblChatName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblChatName.Location = new System.Drawing.Point(20, 592);
            this.lblChatName.Name = "lblChatName";
            this.lblChatName.Size = new System.Drawing.Size(855, 41);
            this.lblChatName.TabIndex = 11;
            this.lblChatName.Text = "CHAT NAME";
            this.lblChatName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmShowChats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(209)))), ((int)(((byte)(190)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.lblChatName);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pboxMehrakBg);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmShowChats";
            this.Text = "Saved Chat - Mehrak";
            this.Load += new System.EventHandler(this.frmShowChats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxMehrakBg)).EndInit();
            this.pboxMehrakBg.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pboxMehrakBg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblChatName;
    }
}