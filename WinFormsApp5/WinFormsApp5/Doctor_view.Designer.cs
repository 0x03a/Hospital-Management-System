namespace WinFormsApp5
{
    partial class Doctor_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor_view));
            Patient_name_label = new Label();
            Doctor = new Label();
            label2 = new Label();
            Tappbtn = new Button();
            medicalhisBtn = new Button();
            label13 = new Label();
            label15 = new Label();
            label3 = new Label();
            label6 = new Label();
            Doctor_Email = new Label();
            label10 = new Label();
            Doctor_Sal_label = new Label();
            label12 = new Label();
            label5 = new Label();
            Doc_Name = new Label();
            Doc_Password = new Label();
            Doc_Email = new Label();
            Doc_Gender = new Label();
            Doc_Sal = new Label();
            Qualification_label = new Label();
            Doc_Qual = new Label();
            label7 = new Label();
            logoutbtn = new Button();
            label1 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Patient_name_label
            // 
            Patient_name_label.BackColor = Color.FromArgb(16, 122, 84);
            Patient_name_label.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Patient_name_label.ForeColor = Color.White;
            Patient_name_label.Location = new Point(0, 167);
            Patient_name_label.Margin = new Padding(5, 0, 5, 0);
            Patient_name_label.Name = "Patient_name_label";
            Patient_name_label.Padding = new Padding(235, 25, 0, 0);
            Patient_name_label.Size = new Size(529, 195);
            Patient_name_label.TabIndex = 7;
            Patient_name_label.Text = "Doctor";
            // 
            // Doctor
            // 
            Doctor.AutoSize = true;
            Doctor.BackColor = Color.FromArgb(16, 122, 84);
            Doctor.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Doctor.ForeColor = Color.White;
            Doctor.Location = new Point(232, 265);
            Doctor.Margin = new Padding(5, 0, 5, 0);
            Doctor.Name = "Doctor";
            Doctor.Size = new Size(177, 32);
            Doctor.TabIndex = 8;
            Doctor.Text = "Doctor_Name";
            Doctor.Click += Doctor_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.BackColor = Color.FromArgb(16, 122, 84);
            label2.Location = new Point(0, 346);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 300);
            label2.Size = new Size(529, 2029);
            label2.TabIndex = 9;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tappbtn
            // 
            Tappbtn.BackColor = Color.FromArgb(232, 232, 232);
            Tappbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Tappbtn.ForeColor = Color.FromArgb(16, 122, 84);
            Tappbtn.Location = new Point(0, 477);
            Tappbtn.Margin = new Padding(5, 3, 5, 3);
            Tappbtn.Name = "Tappbtn";
            Tappbtn.Size = new Size(529, 80);
            Tappbtn.TabIndex = 34;
            Tappbtn.Text = "Total Apointments";
            Tappbtn.UseVisualStyleBackColor = false;
            Tappbtn.Click += Tappbtn_Click;
            // 
            // medicalhisBtn
            // 
            medicalhisBtn.BackColor = Color.FromArgb(232, 232, 232);
            medicalhisBtn.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            medicalhisBtn.ForeColor = Color.FromArgb(16, 122, 84);
            medicalhisBtn.Location = new Point(0, 552);
            medicalhisBtn.Margin = new Padding(5, 3, 5, 3);
            medicalhisBtn.Name = "medicalhisBtn";
            medicalhisBtn.Size = new Size(529, 64);
            medicalhisBtn.TabIndex = 35;
            medicalhisBtn.Text = "Medical history";
            medicalhisBtn.UseVisualStyleBackColor = false;
            medicalhisBtn.Click += medicalhisBtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(538, 101);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(236, 32);
            label13.TabIndex = 52;
            label13.Text = "Detail Information";
            // 
            // label15
            // 
            label15.BorderStyle = BorderStyle.Fixed3D;
            label15.Location = new Point(538, 133);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(300, 3);
            label15.TabIndex = 54;
            label15.Text = "label15";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(666, 238);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 55;
            label3.Text = "Name:  ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(1041, 237);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 26);
            label6.TabIndex = 56;
            label6.Text = "Password:";
            // 
            // Doctor_Email
            // 
            Doctor_Email.AutoSize = true;
            Doctor_Email.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Doctor_Email.ForeColor = Color.Black;
            Doctor_Email.Location = new Point(1452, 237);
            Doctor_Email.Margin = new Padding(4, 0, 4, 0);
            Doctor_Email.Name = "Doctor_Email";
            Doctor_Email.Size = new Size(81, 26);
            Doctor_Email.TabIndex = 58;
            Doctor_Email.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(666, 468);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(97, 26);
            label10.TabIndex = 59;
            label10.Text = "Gender:";
            // 
            // Doctor_Sal_label
            // 
            Doctor_Sal_label.AutoSize = true;
            Doctor_Sal_label.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Doctor_Sal_label.ForeColor = Color.Black;
            Doctor_Sal_label.Location = new Point(1072, 466);
            Doctor_Sal_label.Margin = new Padding(4, 0, 4, 0);
            Doctor_Sal_label.Name = "Doctor_Sal_label";
            Doctor_Sal_label.Size = new Size(87, 26);
            Doctor_Sal_label.TabIndex = 60;
            Doctor_Sal_label.Text = "Salary:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Location = new Point(529, 270);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(591, 3);
            label12.TabIndex = 61;
            label12.Text = "label12";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(526, 497);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(1191, 3);
            label5.TabIndex = 62;
            label5.Text = "label5";
            // 
            // Doc_Name
            // 
            Doc_Name.ForeColor = Color.Black;
            Doc_Name.Location = new Point(752, 237);
            Doc_Name.Margin = new Padding(4, 0, 4, 0);
            Doc_Name.Name = "Doc_Name";
            Doc_Name.Size = new Size(212, 25);
            Doc_Name.TabIndex = 63;
            Doc_Name.Text = "Doc_Name";
            Doc_Name.Click += Doc_Name_Click;
            // 
            // Doc_Password
            // 
            Doc_Password.AutoSize = true;
            Doc_Password.ForeColor = Color.Black;
            Doc_Password.Location = new Point(1166, 237);
            Doc_Password.Name = "Doc_Password";
            Doc_Password.Size = new Size(151, 25);
            Doc_Password.TabIndex = 64;
            Doc_Password.Text = "Doc_Password";
            Doc_Password.Click += Doc_Password_Click;
            // 
            // Doc_Email
            // 
            Doc_Email.AutoSize = true;
            Doc_Email.ForeColor = Color.Black;
            Doc_Email.Location = new Point(1540, 237);
            Doc_Email.Name = "Doc_Email";
            Doc_Email.Size = new Size(116, 25);
            Doc_Email.TabIndex = 65;
            Doc_Email.Text = "Doc_Email";
            Doc_Email.Click += Doc_Email_Click;
            // 
            // Doc_Gender
            // 
            Doc_Gender.AutoSize = true;
            Doc_Gender.ForeColor = Color.Black;
            Doc_Gender.Location = new Point(770, 468);
            Doc_Gender.Name = "Doc_Gender";
            Doc_Gender.Size = new Size(130, 25);
            Doc_Gender.TabIndex = 66;
            Doc_Gender.Text = "Doc_Gender";
            Doc_Gender.Click += Doc_Gender_Click;
            // 
            // Doc_Sal
            // 
            Doc_Sal.AutoSize = true;
            Doc_Sal.ForeColor = Color.Black;
            Doc_Sal.Location = new Point(1176, 466);
            Doc_Sal.Name = "Doc_Sal";
            Doc_Sal.Size = new Size(89, 25);
            Doc_Sal.TabIndex = 67;
            Doc_Sal.Text = "Doc_Sal";
            Doc_Sal.Click += Doc_Sal_Click;
            // 
            // Qualification_label
            // 
            Qualification_label.AutoSize = true;
            Qualification_label.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Qualification_label.ForeColor = Color.Black;
            Qualification_label.Location = new Point(666, 662);
            Qualification_label.Margin = new Padding(4, 0, 4, 0);
            Qualification_label.Name = "Qualification_label";
            Qualification_label.Size = new Size(155, 26);
            Qualification_label.TabIndex = 69;
            Qualification_label.Text = "Qualification:";
            // 
            // Doc_Qual
            // 
            Doc_Qual.AutoSize = true;
            Doc_Qual.ForeColor = Color.Black;
            Doc_Qual.Location = new Point(828, 662);
            Doc_Qual.Name = "Doc_Qual";
            Doc_Qual.Size = new Size(106, 25);
            Doc_Qual.TabIndex = 70;
            Doc_Qual.Text = "Doc_Qual";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(529, 697);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(1164, 3);
            label7.TabIndex = 71;
            label7.Text = "label7";
            // 
            // logoutbtn
            // 
            logoutbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logoutbtn.BackColor = SystemColors.Highlight;
            logoutbtn.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            logoutbtn.ForeColor = Color.White;
            logoutbtn.Location = new Point(1573, 11);
            logoutbtn.Margin = new Padding(4, 2, 4, 2);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(133, 55);
            logoutbtn.TabIndex = 72;
            logoutbtn.Text = "LOG OUT";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(232, 232, 232);
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(44, 125, 147);
            label1.Location = new Point(0, 3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(550, 25, 0, 0);
            label1.Size = new Size(2395, 80);
            label1.TabIndex = 73;
            label1.Text = "HOSPITAL MANAGEMENT ";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(16, 122, 84);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(0, 3);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(529, 184);
            label4.TabIndex = 74;
            // 
            // Doctor_view
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 232, 232);
            ClientSize = new Size(1719, 764);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(logoutbtn);
            Controls.Add(label7);
            Controls.Add(Doc_Qual);
            Controls.Add(Qualification_label);
            Controls.Add(Doc_Sal);
            Controls.Add(Doc_Gender);
            Controls.Add(Doc_Email);
            Controls.Add(Doc_Password);
            Controls.Add(Doc_Name);
            Controls.Add(label5);
            Controls.Add(label12);
            Controls.Add(Doctor_Sal_label);
            Controls.Add(label10);
            Controls.Add(Doctor_Email);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(medicalhisBtn);
            Controls.Add(Tappbtn);
            Controls.Add(label2);
            Controls.Add(Doctor);
            Controls.Add(Patient_name_label);
            Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Doctor_view";
            Text = "Doctor_view";
            Load += Doctor_view_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Patient_name_label;
        private Label Doctor;
        private Label label2;
        private Button Tappbtn;
        private Button medicalhisBtn;
        private Label label13;
        private Label label15;
        private Label label3;
        private Label label6;
        private Label Doctor_Email;
        private Label label10;
        private Label Doctor_Sal_label;
        private Label label12;
        private Label label5;
        private Label Doc_Name;
        private Label Doc_Password;
        private Label Doc_Email;
        private Label Doc_Gender;
        private Label Doc_Sal;
        private Label Qualification_label;
        private Label Doc_Qual;
        private Label label7;
        private Button logoutbtn;
        private Label label1;
        private Label label4;
    }
}