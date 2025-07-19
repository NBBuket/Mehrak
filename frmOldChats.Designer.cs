namespace Mehrak
{
    partial class frmOldChats
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlChatList = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pboxKaveh = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnlMain.SuspendLayout();
            this.pnlChatList.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKaveh)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(179)))), ((int)(((byte)(128)))));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.pnlChatList);
            this.pnlMain.Controls.Add(this.pnlButtons);
            this.pnlMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(179)))), ((int)(((byte)(128)))));
            this.pnlMain.Location = new System.Drawing.Point(25, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(850, 550);
            this.pnlMain.TabIndex = 6;
            // 
            // pnlChatList
            // 
            this.pnlChatList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(209)))), ((int)(((byte)(190)))));
            this.pnlChatList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlChatList.Controls.Add(this.listBox1);
            this.pnlChatList.Location = new System.Drawing.Point(21, 25);
            this.pnlChatList.Margin = new System.Windows.Forms.Padding(2);
            this.pnlChatList.Name = "pnlChatList";
            this.pnlChatList.Size = new System.Drawing.Size(466, 468);
            this.pnlChatList.TabIndex = 1;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(209)))), ((int)(((byte)(190)))));
            this.pnlButtons.Controls.Add(this.btnBack);
            this.pnlButtons.Controls.Add(this.pboxKaveh);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnReload);
            this.pnlButtons.Location = new System.Drawing.Point(532, 25);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(2);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(290, 468);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(36, 406);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(218, 41);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Main Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pboxKaveh
            // 
            this.pboxKaveh.BackgroundImage = global::Mehrak.Properties.Resources.genshin_genshin_impact;
            this.pboxKaveh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxKaveh.Image = global::Mehrak.Properties.Resources.genshin_genshin_impact;
            this.pboxKaveh.Location = new System.Drawing.Point(24, 20);
            this.pboxKaveh.Name = "pboxKaveh";
            this.pboxKaveh.Size = new System.Drawing.Size(245, 216);
            this.pboxKaveh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxKaveh.TabIndex = 2;
            this.pboxKaveh.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btnDelete.Location = new System.Drawing.Point(36, 336);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(218, 41);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Chat";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.btnReload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btnReload.Location = new System.Drawing.Point(36, 266);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(218, 41);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload Chat";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(209)))), ((int)(((byte)(190)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(0, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 434);
            this.listBox1.TabIndex = 17;
            // 
            // frmOldChats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOldChats";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmOldChats_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlChatList.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxKaveh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlChatList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.PictureBox pboxKaveh;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox listBox1;
    }
}