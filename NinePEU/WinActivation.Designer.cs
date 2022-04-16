namespace NinePEU
{
    partial class WinActivation
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
            this.Activate = new RJCodeAdvance.RJControls.RJButton();
            this.Version = new RJCodeAdvance.RJControls.RJComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Marker = new System.Windows.Forms.PictureBox();
            this.AtStat = new RJCodeAdvance.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Marker)).BeginInit();
            this.SuspendLayout();
            // 
            // Activate
            // 
            this.Activate.BackColor = System.Drawing.Color.Lime;
            this.Activate.BackgroundColor = System.Drawing.Color.Lime;
            this.Activate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Activate.BorderRadius = 0;
            this.Activate.BorderSize = 0;
            this.Activate.FlatAppearance.BorderSize = 0;
            this.Activate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Activate.Font = new System.Drawing.Font("Noto Mono for Powerline", 33F, System.Drawing.FontStyle.Bold);
            this.Activate.ForeColor = System.Drawing.Color.White;
            this.Activate.Location = new System.Drawing.Point(18, 152);
            this.Activate.Name = "Activate";
            this.Activate.Size = new System.Drawing.Size(263, 172);
            this.Activate.TabIndex = 0;
            this.Activate.Text = "Activate";
            this.Activate.TextColor = System.Drawing.Color.White;
            this.Activate.UseVisualStyleBackColor = false;
            this.Activate.Click += new System.EventHandler(this.Activate_Click);
            // 
            // Version
            // 
            this.Version.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Version.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Version.BorderSize = 1;
            this.Version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Version.ForeColor = System.Drawing.Color.DimGray;
            this.Version.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.Version.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.Version.ListTextColor = System.Drawing.Color.DimGray;
            this.Version.Location = new System.Drawing.Point(18, 106);
            this.Version.MinimumSize = new System.Drawing.Size(200, 30);
            this.Version.Name = "Version";
            this.Version.Padding = new System.Windows.Forms.Padding(1);
            this.Version.Size = new System.Drawing.Size(263, 30);
            this.Version.TabIndex = 1;
            this.Version.Texts = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Mono for Powerline", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Windows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Mono for Powerline", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Activation Wizard";
            // 
            // Marker
            // 
            this.Marker.BackColor = System.Drawing.Color.Black;
            this.Marker.Location = new System.Drawing.Point(287, -27);
            this.Marker.Name = "Marker";
            this.Marker.Size = new System.Drawing.Size(14, 468);
            this.Marker.TabIndex = 4;
            this.Marker.TabStop = false;
            // 
            // AtStat
            // 
            this.AtStat.BackColor = System.Drawing.SystemColors.Window;
            this.AtStat.BorderColor = System.Drawing.Color.White;
            this.AtStat.BorderFocusColor = System.Drawing.Color.HotPink;
            this.AtStat.BorderRadius = 0;
            this.AtStat.BorderSize = 2;
            this.AtStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AtStat.Location = new System.Drawing.Point(390, 31);
            this.AtStat.Margin = new System.Windows.Forms.Padding(4);
            this.AtStat.Multiline = false;
            this.AtStat.Name = "AtStat";
            this.AtStat.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.AtStat.PasswordChar = false;
            this.AtStat.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.AtStat.PlaceholderText = "";
            this.AtStat.Size = new System.Drawing.Size(250, 31);
            this.AtStat.TabIndex = 5;
            this.AtStat.Texts = "";
            this.AtStat.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Mono for Powerline", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Activation Status";
            // 
            // WinActivation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 336);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AtStat);
            this.Controls.Add(this.Marker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Activate);
            this.Name = "WinActivation";
            this.Text = "WinActivation";
            this.Load += new System.EventHandler(this.WinActivation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Marker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton Activate;
        private RJCodeAdvance.RJControls.RJComboBox Version;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Marker;
        private RJCodeAdvance.RJControls.RJTextBox AtStat;
        private System.Windows.Forms.Label label3;
    }
}