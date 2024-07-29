namespace NewProject
{
    partial class SplashForm
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
            picLogo = new PictureBox();
            lblAppName = new Label();
            lblLoading = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.AntiqueWhite;
            picLogo.Image = Properties.Resources.OIP;
            picLogo.Location = new Point(272, 100);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(256, 218);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblAppName
            // 
            lblAppName.BackColor = SystemColors.ButtonShadow;
            lblAppName.Font = new Font("Segoe Print", 13.875F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = SystemColors.Control;
            lblAppName.Location = new Point(232, 341);
            lblAppName.Margin = new Padding(6, 0, 6, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(327, 63);
            lblAppName.TabIndex = 10;
            lblAppName.Text = "Delphina Hotel";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Location = new Point(335, 447);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(114, 32);
            lblLoading.TabIndex = 11;
            lblLoading.Text = "Loading...";
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(788, 524);
            Controls.Add(lblLoading);
            Controls.Add(lblAppName);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSplash";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblAppName;
        private Label lblLoading;
    }
}