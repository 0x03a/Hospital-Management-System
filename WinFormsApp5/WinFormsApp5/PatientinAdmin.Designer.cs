namespace WinFormsApp5
{
    partial class PatientinAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientinAdmin));
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button7 = new Button();
            button8 = new Button();
            button5 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(232, 232, 232);
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(44, 125, 147);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(320, 25, 0, 0);
            label1.Size = new Size(1405, 80);
            label1.TabIndex = 2;
            label1.Text = "HOSPITAL MANAGEMENT ";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(16, 122, 84);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(313, 184);
            label4.TabIndex = 5;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(16, 122, 84);
            label3.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(0, 184);
            label3.Name = "label3";
            label3.Padding = new Padding(125, 0, 0, 0);
            label3.Size = new Size(313, 113);
            label3.TabIndex = 6;
            label3.Text = "Admin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(16, 122, 84);
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(109, 254);
            label5.Name = "label5";
            label5.Size = new Size(89, 32);
            label5.TabIndex = 7;
            label5.Text = "Inshal";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.BackColor = Color.FromArgb(16, 122, 84);
            label2.Location = new Point(0, 297);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 300);
            label2.Size = new Size(313, 1152);
            label2.TabIndex = 8;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(232, 232, 232);
            button1.FlatAppearance.BorderColor = Color.FromArgb(16, 122, 84);
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(0, 384);
            button1.Name = "button1";
            button1.Size = new Size(313, 67);
            button1.TabIndex = 31;
            button1.Text = "Doctors";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(232, 232, 232);
            button2.FlatAppearance.BorderColor = Color.FromArgb(16, 122, 84);
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(0, 447);
            button2.Name = "button2";
            button2.Size = new Size(313, 69);
            button2.TabIndex = 32;
            button2.Text = "Patients";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(232, 232, 232);
            button7.FlatAppearance.BorderColor = Color.FromArgb(16, 122, 84);
            button7.FlatAppearance.BorderSize = 3;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(0, 514);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(315, 92);
            button7.TabIndex = 34;
            button7.Text = "Total Appointments";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(232, 232, 232);
            button8.FlatAppearance.BorderColor = Color.FromArgb(16, 122, 84);
            button8.FlatAppearance.BorderSize = 3;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(-2, 600);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(315, 92);
            button8.TabIndex = 35;
            button8.Text = "Nurses";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(232, 232, 232);
            button5.FlatAppearance.BorderColor = Color.FromArgb(16, 122, 84);
            button5.FlatAppearance.BorderSize = 3;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(0, 683);
            button5.Name = "button5";
            button5.Size = new Size(313, 95);
            button5.TabIndex = 36;
            button5.Text = "Receptionists";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(16, 122, 84);
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1242, 11);
            button4.Margin = new Padding(4, 2, 4, 2);
            button4.Name = "button4";
            button4.Size = new Size(133, 55);
            button4.TabIndex = 37;
            button4.Text = "LOG OUT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(341, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1034, 422);
            dataGridView1.TabIndex = 38;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(361, 181);
            label6.Name = "label6";
            label6.Size = new Size(186, 25);
            label6.TabIndex = 39;
            label6.Text = "PATIENT TABLE";
            // 
            // PatientinAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 884);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "PatientinAdmin";
            Text = "PatientinAdmin";
            Load += PatientinAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button7;
        private Button button8;
        private Button button5;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label6;
    }
}