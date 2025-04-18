namespace WinFormsApp5
{
    partial class Total_Appointments_in_PatientView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Total_Appointments_in_PatientView));
            label1 = new Label();
            label4 = new Label();
            Patient_name_label = new Label();
            label2 = new Label();
            Tappbtn = new Button();
            medicalhisBtn = new Button();
            button5 = new Button();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            logoutbtn = new Button();
            label5 = new Label();
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
            label1.Location = new Point(-4, -3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(416, 25, 0, 0);
            label1.Size = new Size(2395, 80);
            label1.TabIndex = 3;
            label1.Text = "HOSPITAL MANAGEMENT ";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(16, 122, 84);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(-4, -3);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(407, 184);
            label4.TabIndex = 42;
            // 
            // Patient_name_label
            // 
            Patient_name_label.BackColor = Color.FromArgb(16, 122, 84);
            Patient_name_label.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Patient_name_label.ForeColor = Color.White;
            Patient_name_label.Location = new Point(-4, 181);
            Patient_name_label.Margin = new Padding(4, 0, 4, 0);
            Patient_name_label.Name = "Patient_name_label";
            Patient_name_label.Padding = new Padding(162, 25, 0, 0);
            Patient_name_label.Size = new Size(407, 195);
            Patient_name_label.TabIndex = 43;
            Patient_name_label.Text = "Patient";
            Patient_name_label.Click += Patient_name_label_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.BackColor = Color.FromArgb(16, 122, 84);
            label2.Location = new Point(-4, 376);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 300);
            label2.Size = new Size(407, 1760);
            label2.TabIndex = 44;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tappbtn
            // 
            Tappbtn.BackColor = Color.FromArgb(232, 232, 232);
            Tappbtn.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            Tappbtn.FlatAppearance.BorderSize = 3;
            Tappbtn.FlatStyle = FlatStyle.Flat;
            Tappbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Tappbtn.ForeColor = Color.FromArgb(16, 122, 84);
            Tappbtn.Location = new Point(-4, 434);
            Tappbtn.Margin = new Padding(4, 3, 4, 3);
            Tappbtn.Name = "Tappbtn";
            Tappbtn.Size = new Size(407, 80);
            Tappbtn.TabIndex = 45;
            Tappbtn.Text = "Total Apointments";
            Tappbtn.UseVisualStyleBackColor = false;
            Tappbtn.Click += Tappbtn_Click;
            // 
            // medicalhisBtn
            // 
            medicalhisBtn.BackColor = Color.FromArgb(232, 232, 232);
            medicalhisBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            medicalhisBtn.FlatAppearance.BorderSize = 3;
            medicalhisBtn.FlatStyle = FlatStyle.Flat;
            medicalhisBtn.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            medicalhisBtn.ForeColor = Color.FromArgb(16, 122, 84);
            medicalhisBtn.Location = new Point(-4, 508);
            medicalhisBtn.Margin = new Padding(4, 3, 4, 3);
            medicalhisBtn.Name = "medicalhisBtn";
            medicalhisBtn.Size = new Size(407, 64);
            medicalhisBtn.TabIndex = 46;
            medicalhisBtn.Text = "Medical history";
            medicalhisBtn.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(232, 232, 232);
            button5.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            button5.FlatAppearance.BorderSize = 3;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(16, 122, 84);
            button5.Location = new Point(-4, 565);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(407, 68);
            button5.TabIndex = 47;
            button5.Text = "Receptionists";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(449, 139);
            label3.Name = "label3";
            label3.Size = new Size(368, 36);
            label3.TabIndex = 48;
            label3.Text = "Total Appointments Table";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(467, 243);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(811, 366);
            dataGridView1.TabIndex = 49;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // logoutbtn
            // 
            logoutbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logoutbtn.BackColor = Color.FromArgb(16, 122, 84);
            logoutbtn.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            logoutbtn.ForeColor = Color.White;
            logoutbtn.Location = new Point(1165, 11);
            logoutbtn.Margin = new Padding(4, 2, 4, 2);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(133, 55);
            logoutbtn.TabIndex = 59;
            logoutbtn.Text = "LOG OUT";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(16, 122, 84);
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(157, 272);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(182, 32);
            label5.TabIndex = 60;
            label5.Text = "Patient_Name";
            label5.Click += label5_Click;
            // 
            // Total_Appointments_in_PatientView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 833);
            Controls.Add(label5);
            Controls.Add(logoutbtn);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(medicalhisBtn);
            Controls.Add(Tappbtn);
            Controls.Add(label2);
            Controls.Add(Patient_name_label);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Total_Appointments_in_PatientView";
            Text = "Total_Appointments_in_PatientView";
            Load += Total_Appointments_in_PatientView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label Patient_name_label;
        private Label label2;
        private Button Tappbtn;
        private Button medicalhisBtn;
        private Button button5;
        private Label label3;
        private DataGridView dataGridView1;
        private Button logoutbtn;
        private Label label5;
    }
}