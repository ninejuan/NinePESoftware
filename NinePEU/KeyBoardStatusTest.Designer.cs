namespace NinePEU
{
    partial class KeyBoardStatusTest
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
            this.KeyBox = new RJCodeAdvance.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // KeyBox
            // 
            this.KeyBox.BackColor = System.Drawing.SystemColors.Window;
            this.KeyBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.KeyBox.BorderFocusColor = System.Drawing.Color.Lime;
            this.KeyBox.BorderRadius = 0;
            this.KeyBox.BorderSize = 2;
            this.KeyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KeyBox.Location = new System.Drawing.Point(12, 13);
            this.KeyBox.Margin = new System.Windows.Forms.Padding(4);
            this.KeyBox.Multiline = false;
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.KeyBox.PasswordChar = false;
            this.KeyBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.KeyBox.PlaceholderText = "";
            this.KeyBox.Size = new System.Drawing.Size(303, 31);
            this.KeyBox.TabIndex = 0;
            this.KeyBox.Texts = "";
            this.KeyBox.UnderlinedStyle = false;
            this.KeyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyBox_KeyDown);
            // 
            // KeyBoardStatusTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 64);
            this.Controls.Add(this.KeyBox);
            this.Name = "KeyBoardStatusTest";
            this.Text = "KeyBoardStatusTest";
            this.Load += new System.EventHandler(this.KeyBoardStatusTest_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyBoardStatusTest_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private RJCodeAdvance.RJControls.RJTextBox KeyBox;
    }
}