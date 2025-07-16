namespace Mehrak
{
    partial class frmSaveAs
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
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.txtChatName = new System.Windows.Forms.TextBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblSaveText = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(179)))), ((int)(((byte)(128)))));
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBackground.Controls.Add(this.lblSaveText);
            this.pnlBackground.Controls.Add(this.btnOk);
            this.pnlBackground.Controls.Add(this.txtChatName);
            this.pnlBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBackground.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(179)))), ((int)(((byte)(128)))));
            this.pnlBackground.Location = new System.Drawing.Point(25, 38);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(550, 350);
            this.pnlBackground.TabIndex = 7;
            // 
            // txtChatName
            // 
            this.txtChatName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.txtChatName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChatName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.txtChatName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(204)))), ((int)(((byte)(125)))));
            this.txtChatName.Location = new System.Drawing.Point(12, 167);
            this.txtChatName.Margin = new System.Windows.Forms.Padding(2);
            this.txtChatName.Multiline = true;
            this.txtChatName.Name = "txtChatName";
            this.txtChatName.Size = new System.Drawing.Size(501, 53);
            this.txtChatName.TabIndex = 1;
            this.txtChatName.Text = "...";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            this.btnMinimize.Location = new System.Drawing.Point(488, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 25);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Text = "⎯";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.minWindow_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            this.btnClose.Location = new System.Drawing.Point(534, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 25);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(92)))));
            this.btnOk.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            this.btnOk.Location = new System.Drawing.Point(413, 246);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 50);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.okButton_Click);
            // 
            // lblSaveText
            // 
            this.lblSaveText.AutoSize = true;
            this.lblSaveText.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold);
            this.lblSaveText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(204)))), ((int)(((byte)(125)))));
            this.lblSaveText.Location = new System.Drawing.Point(13, 57);
            this.lblSaveText.Name = "lblSaveText";
            this.lblSaveText.Size = new System.Drawing.Size(396, 55);
            this.lblSaveText.TabIndex = 8;
            this.lblSaveText.Text = "Save this chat as...";
            // 
            // frmSaveAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSaveAs";
            this.Text = "Form3";
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtChatName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblSaveText;
    }
}