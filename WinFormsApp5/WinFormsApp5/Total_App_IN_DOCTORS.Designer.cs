namespace WinFormsApp5
{
    partial class Total_App_IN_DOCTORS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Total_App_IN_DOCTORS));
            label1 = new Label();
            label4 = new Label();
            Patient_name_label = new Label();
            Doctor = new Label();
            label2 = new Label();
            Tappbtn = new Button();
            medicalhisBtn = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            logoutbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(232, 232, 232);
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(44, 125, 147);
            label1.Location = new Point(-3, -3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(550, 25, 0, 0);
            label1.Size = new Size(2446, 80);
            label1.TabIndex = 74;
            label1.Text = "HOSPITAL MANAGEMENT ";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(16, 122, 84);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(-3, -3);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(529, 184);
            label4.TabIndex = 75;
            // 
            // Patient_name_label
            // 
            Patient_name_label.BackColor = Color.FromArgb(16, 122, 84);
            Patient_name_label.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Patient_name_label.ForeColor = Color.White;
            Patient_name_label.Location = new Point(-3, 158);
            Patient_name_label.Margin = new Padding(5, 0, 5, 0);
            Patient_name_label.Name = "Patient_name_label";
            Patient_name_label.Padding = new Padding(235, 25, 0, 0);
            Patient_name_label.Size = new Size(529, 195);
            Patient_name_label.TabIndex = 76;
            Patient_name_label.Text = "Doctor";
            // 
            // Doctor
            // 
            Doctor.AutoSize = true;
            Doctor.BackColor = Color.FromArgb(16, 122, 84);
            Doctor.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Doctor.ForeColor = Color.White;
            Doctor.Location = new Point(226, 223);
            Doctor.Margin = new Padding(5, 0, 5, 0);
            Doctor.Name = "Doctor";
            Doctor.Size = new Size(177, 32);
            Doctor.TabIndex = 77;
            Doctor.Text = "Doctor_Name";
            Doctor.Click += Doctor_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.BackColor = Color.FromArgb(16, 122, 84);
            label2.Location = new Point(-3, 353);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 300);
            label2.Size = new Size(529, 2029);
            label2.TabIndex = 78;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tappbtn
            // 
            Tappbtn.BackColor = Color.FromArgb(232, 232, 232);
            Tappbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Tappbtn.ForeColor = Color.FromArgb(16, 122, 84);
            Tappbtn.Location = new Point(-3, 456);
            Tappbtn.Margin = new Padding(5, 3, 5, 3);
            Tappbtn.Name = "Tappbtn";
            Tappbtn.Size = new Size(529, 80);
            Tappbtn.TabIndex = 79;
            Tappbtn.Text = "Total Apointments";
            Tappbtn.UseVisualStyleBackColor = false;
            Tappbtn.Click += Tappbtn_Click;
            // 
            // medicalhisBtn
            // 
            medicalhisBtn.BackColor = Color.FromArgb(232, 232, 232);
            medicalhisBtn.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            medicalhisBtn.ForeColor = Color.FromArgb(16, 122, 84);
            medicalhisBtn.Location = new Point(-3, 533);
            medicalhisBtn.Margin = new Padding(5, 3, 5, 3);
            medicalhisBtn.Name = "medicalhisBtn";
            medicalhisBtn.Size = new Size(529, 64);
            medicalhisBtn.TabIndex = 80;
            medicalhisBtn.Text = "Medical history";
            medicalhisBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(591, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(752, 366);
            dataGridView1.TabIndex = 81;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(591, 147);
            label3.Name = "label3";
            label3.Size = new Size(368, 36);
            label3.TabIndex = 82;
            label3.Text = "Total Appointments Table";
            // 
            // logoutbtn
            // 
            logoutbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logoutbtn.BackColor = Color.FromArgb(16, 122, 84);
            logoutbtn.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            logoutbtn.ForeColor = Color.White;
            logoutbtn.Location = new Point(1240, 11);
            logoutbtn.Margin = new Padding(4, 2, 4, 2);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(133, 55);
            logoutbtn.TabIndex = 83;
            logoutbtn.Text = "LOG OUT";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // Total_App_IN_DOCTORS
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 840);
            Controls.Add(logoutbtn);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(medicalhisBtn);
            Controls.Add(Tappbtn);
            Controls.Add(label2);
            Controls.Add(Doctor);
            Controls.Add(Patient_name_label);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Total_App_IN_DOCTORS";
            Text = "Total_App_IN_DOCTORS";
            Load += Total_App_IN_DOCTORS_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label Patient_name_label;
        private Label Doctor;
        private Label label2;
        private Button Tappbtn;
        private Button medicalhisBtn;
        private DataGridView dataGridView1;
        private Label label3;
        private Button logoutbtn;
    }
}