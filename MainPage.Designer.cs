namespace Mehrak
{
    partial class MainPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minWindow = new System.Windows.Forms.Button();
            this.closeWindow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleName = "newChat";
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(92)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(447, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 175);
            this.button1.TabIndex = 0;
            this.button1.Text = "NEW CHAT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.newChat_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(92)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(136, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 175);
            this.button2.TabIndex = 1;
            this.button2.Text = "OLD CHATS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(179)))), ((int)(((byte)(128)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(179)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(26, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 394);
            this.panel1.TabIndex = 2;
            // 
            // minWindow
            // 
            this.minWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            this.minWindow.Location = new System.Drawing.Point(683, 0);
            this.minWindow.Name = "minWindow";
            this.minWindow.Size = new System.Drawing.Size(39, 24);
            this.minWindow.TabIndex = 2;
            this.minWindow.Text = "⎯";
            this.minWindow.UseVisualStyleBackColor = true;
            this.minWindow.Click += new System.EventHandler(this.minWindow_Click);
            // 
            // closeWindow
            // 
            this.closeWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            this.closeWindow.Location = new System.Drawing.Point(728, 0);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(39, 24);
            this.closeWindow.TabIndex = 3;
            this.closeWindow.Text = "X";
            this.closeWindow.UseVisualStyleBackColor = true;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // MainPage
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(790, 445);
            this.Controls.Add(this.closeWindow);
            this.Controls.Add(this.minWindow);
            this.Controls.Add(this.panel1);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minWindow;
        private System.Windows.Forms.Button closeWindow;
    }
}

