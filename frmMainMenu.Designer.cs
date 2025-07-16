namespace Mehrak
{
    partial class frmMainMenu
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
            this.btnNewChat = new System.Windows.Forms.Button();
            this.btnOldChat = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewChat
            // 
            this.btnNewChat.AccessibleName = "newChat";
            this.btnNewChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(92)))));
            this.btnNewChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewChat.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNewChat.FlatAppearance.BorderSize = 0;
            this.btnNewChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewChat.Font = new System.Drawing.Font("Times New Roman", 27F, System.Drawing.FontStyle.Bold);
            this.btnNewChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btnNewChat.Location = new System.Drawing.Point(487, 175);
            this.btnNewChat.Name = "btnNewChat";
            this.btnNewChat.Size = new System.Drawing.Size(150, 200);
            this.btnNewChat.TabIndex = 0;
            this.btnNewChat.Text = "NEW CHAT";
            this.btnNewChat.UseVisualStyleBackColor = false;
            this.btnNewChat.Click += new System.EventHandler(this.newChat_Click);
            // 
            // btnOldChat
            // 
            this.btnOldChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(92)))));
            this.btnOldChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOldChat.FlatAppearance.BorderSize = 0;
            this.btnOldChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOldChat.Font = new System.Drawing.Font("Times New Roman", 27F, System.Drawing.FontStyle.Bold);
            this.btnOldChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btnOldChat.Location = new System.Drawing.Point(213, 175);
            this.btnOldChat.Name = "btnOldChat";
            this.btnOldChat.Size = new System.Drawing.Size(150, 200);
            this.btnOldChat.TabIndex = 1;
            this.btnOldChat.Text = "OLD CHATS";
            this.btnOldChat.UseVisualStyleBackColor = false;
            this.btnOldChat.Click += new System.EventHandler(this.oldChat_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(179)))), ((int)(((byte)(128)))));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMain.Controls.Add(this.btnOldChat);
            this.pnlMain.Controls.Add(this.btnNewChat);
            this.pnlMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(179)))), ((int)(((byte)(128)))));
            this.pnlMain.Location = new System.Drawing.Point(25, 50);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(850, 550);
            this.pnlMain.TabIndex = 2;
            // 
            // frmMainMenu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 539);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainMenu";
            this.Text = "Form1";
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewChat;
        private System.Windows.Forms.Button btnOldChat;
        private System.Windows.Forms.Panel pnlMain;
    }
}

