namespace Mehrak
{
    partial class NewChat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.minWindow = new System.Windows.Forms.Button();
            this.closeWindow = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(27, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 347);
            this.panel1.TabIndex = 0;
            // 
            // minWindow
            // 
            this.minWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(197)))), ((int)(((byte)(165)))));
            this.minWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            this.minWindow.Location = new System.Drawing.Point(697, 2);
            this.minWindow.Name = "minWindow";
            this.minWindow.Size = new System.Drawing.Size(39, 24);
            this.minWindow.TabIndex = 5;
            this.minWindow.Text = "⎯";
            this.minWindow.UseVisualStyleBackColor = false;
            this.minWindow.Click += new System.EventHandler(this.minWindow_Click);
            // 
            // closeWindow
            // 
            this.closeWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(197)))), ((int)(((byte)(165)))));
            this.closeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(64)))));
            this.closeWindow.Location = new System.Drawing.Point(742, 2);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(39, 24);
            this.closeWindow.TabIndex = 7;
            this.closeWindow.Text = "X";
            this.closeWindow.UseVisualStyleBackColor = false;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(92)))));
            this.saveButton.Location = new System.Drawing.Point(27, 389);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(44, 46);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "button1";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(209)))), ((int)(((byte)(190)))));
            this.textBox1.Location = new System.Drawing.Point(172, 389);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(535, 47);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Text here...";
            // 
            // NewChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(209)))), ((int)(((byte)(190)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 445);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.minWindow);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.closeWindow);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewChat";
            this.Text = "NewChat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minWindow;
        private System.Windows.Forms.Button closeWindow;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}