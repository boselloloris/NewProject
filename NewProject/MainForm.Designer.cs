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
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 81);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonShadow;
            label6.Font = new Font("Segoe Print", 8.25F, FontStyle.Italic);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(3, 61);
            label6.Name = "label6";
            label6.Size = new Size(90, 19);
            label6.TabIndex = 9;
            label6.Text = "Delphina Hotel";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 9);
            label1.Name = "label1";
            label1.Size = new Size(684, 65);
            label1.TabIndex = 0;
            label1.Text = "Customer Table Maintenance";
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = SystemColors.Control;
            BtnAdd.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAdd.ForeColor = Color.Black;
            BtnAdd.Location = new Point(613, 10);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(88, 48);
            BtnAdd.TabIndex = 2;
            BtnAdd.Text = "ADD";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnRemove
            // 
            BtnRemove.BackColor = SystemColors.Control;
            BtnRemove.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRemove.ForeColor = Color.Black;
            BtnRemove.Location = new Point(707, 10);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(146, 48);
            BtnRemove.TabIndex = 3;
            BtnRemove.Text = "SAVE";
            BtnRemove.UseVisualStyleBackColor = false;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = SystemColors.Control;
            BtnClose.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClose.ForeColor = Color.Black;
            BtnClose.Location = new Point(859, 10);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(146, 48);
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
            panel3.Location = new Point(0, 659);
            panel3.Name = "panel3";
            panel3.Size = new Size(1008, 70);
            panel3.TabIndex = 5;
            // 
            // DgvCustomer
            // 
            DgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCustomer.Dock = DockStyle.Fill;
            DgvCustomer.Location = new Point(0, 81);
            DgvCustomer.Name = "DgvCustomer";
            DgvCustomer.Size = new Size(1008, 578);
            DgvCustomer.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(DgvCustomer);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "MainForm";
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
