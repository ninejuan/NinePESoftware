namespace NinePEU
{
    partial class MouseStatusTest
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
            this.Clicking = new RJCodeAdvance.RJControls.RJButton();
            this.stat = new RJCodeAdvance.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Clicking
            // 
            this.Clicking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Clicking.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Clicking.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Clicking.BorderRadius = 0;
            this.Clicking.BorderSize = 0;
            this.Clicking.FlatAppearance.BorderSize = 0;
            this.Clicking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clicking.Font = new System.Drawing.Font("Noto Mono for Powerline", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clicking.ForeColor = System.Drawing.Color.White;
            this.Clicking.Location = new System.Drawing.Point(12, 51);
            this.Clicking.Name = "Clicking";
            this.Clicking.Size = new System.Drawing.Size(285, 214);
            this.Clicking.TabIndex = 0;
            this.Clicking.Text = "Click!";
            this.Clicking.TextColor = System.Drawing.Color.White;
            this.Clicking.UseVisualStyleBackColor = false;
            this.Clicking.Click += new System.EventHandler(this.Clicking_Click);
            // 
            // stat
            // 
            this.stat.BackColor = System.Drawing.SystemColors.Window;
            this.stat.BorderColor = System.Drawing.Color.Red;
            this.stat.BorderFocusColor = System.Drawing.Color.HotPink;
            this.stat.BorderRadius = 0;
            this.stat.BorderSize = 2;
            this.stat.Enabled = false;
            this.stat.Font = new System.Drawing.Font("Noto Mono for Powerline", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stat.Location = new System.Drawing.Point(89, 10);
            this.stat.Margin = new System.Windows.Forms.Padding(4);
            this.stat.Multiline = false;
            this.stat.Name = "stat";
            this.stat.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.stat.PasswordChar = false;
            this.stat.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.stat.PlaceholderText = "";
            this.stat.Size = new System.Drawing.Size(197, 34);
            this.stat.TabIndex = 1;
            this.stat.Texts = "Cannot Recognize!";
            this.stat.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Mono for Powerline", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status";
            // 
            // MouseStatusTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 275);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stat);
            this.Controls.Add(this.Clicking);
            this.Name = "MouseStatusTest";
            this.Text = "MouseStatusTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton Clicking;
        private RJCodeAdvance.RJControls.RJTextBox stat;
        private System.Windows.Forms.Label label1;
    }
}