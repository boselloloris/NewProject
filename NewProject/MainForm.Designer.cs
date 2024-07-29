namespace NewProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            BtnAdd = new Button();
            BtnRemove = new Button();
            BtnClose = new Button();
            panel3 = new Panel();
            DgvCustomer = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1874, 173);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonShadow;
            label6.Font = new Font("Segoe Print", 8.25F, FontStyle.Italic);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(6, 130);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(179, 38);
            label6.TabIndex = 9;
            label6.Text = "Delphina Hotel";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 26);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 19);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(1363, 128);
            label1.TabIndex = 0;
            label1.Text = "Customer Table Maintenance";
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnAdd.BackColor = SystemColors.Control;
            BtnAdd.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAdd.ForeColor = Color.Black;
            BtnAdd.Location = new Point(1075, 21);
            BtnAdd.Margin = new Padding(6);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(250, 100);
            BtnAdd.TabIndex = 2;
            BtnAdd.Text = "ADD";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnRemove
            // 
            BtnRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnRemove.BackColor = SystemColors.Control;
            BtnRemove.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRemove.ForeColor = Color.Black;
            BtnRemove.Location = new Point(1337, 21);
            BtnRemove.Margin = new Padding(6);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(250, 100);
            BtnRemove.TabIndex = 3;
            BtnRemove.Text = "SAVE";
            BtnRemove.UseVisualStyleBackColor = false;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnClose.BackColor = SystemColors.Control;
            BtnClose.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClose.ForeColor = Color.Black;
            BtnClose.Location = new Point(1599, 21);
            BtnClose.Margin = new Padding(6);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(250, 100);
            BtnClose.TabIndex = 4;
            BtnClose.Text = "CLOSE";
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Controls.Add(BtnRemove);
            panel3.Controls.Add(BtnAdd);
            panel3.Controls.Add(BtnClose);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 1380);
            panel3.Margin = new Padding(6);
            panel3.Name = "panel3";
            panel3.Size = new Size(1874, 149);
            panel3.TabIndex = 5;
            // 
            // DgvCustomer
            // 
            DgvCustomer.AllowUserToAddRows = false;
            DgvCustomer.AllowUserToDeleteRows = false;
            DgvCustomer.AllowUserToResizeRows = false;
            DgvCustomer.BackgroundColor = SystemColors.Control;
            DgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCustomer.Dock = DockStyle.Fill;
            DgvCustomer.Location = new Point(0, 173);
            DgvCustomer.Margin = new Padding(6);
            DgvCustomer.Name = "DgvCustomer";
            DgvCustomer.ReadOnly = true;
            DgvCustomer.RowHeadersWidth = 82;
            DgvCustomer.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvCustomer.ShowEditingIcon = false;
            DgvCustomer.Size = new Size(1874, 1207);
            DgvCustomer.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1874, 1529);
            Controls.Add(DgvCustomer);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(6);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Table Maintenance";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button BtnAdd;
        private Button BtnRemove;
        private Button BtnClose;
        private Panel panel3;
        private Label label6;
        private DataGridView DgvCustomer;
    }
}
