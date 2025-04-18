namespace WinFormsApp5
{
    partial class Patient_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_View));
            label1 = new Label();
            label4 = new Label();
            Patient_name_label = new Label();
            label5 = new Label();
            label2 = new Label();
            Tappbtn = new Button();
            medicalhisBtn = new Button();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            Patient_Password = new Label();
            Patient_CNIC = new Label();
            Patient_BG = new Label();
            P_Email = new Label();
            P_Gender = new Label();
            P_Address = new Label();
            oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            label12 = new Label();
            label14 = new Label();
            label16 = new Label();
            Patient_Name = new Label();
            button5 = new Button();
            logoutbtn = new Button();
            label15 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(232, 232, 232);
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(44, 125, 147);
            label1.Location = new Point(-1, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(416, 25, 0, 0);
            label1.Size = new Size(2116, 80);
            label1.TabIndex = 2;
            label1.Text = "HOSPITAL MANAGEMENT ";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(16, 122, 84);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(-1, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(407, 184);
            label4.TabIndex = 5;
            // 
            // Patient_name_label
            // 
            Patient_name_label.BackColor = Color.FromArgb(16, 122, 84);
            Patient_name_label.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Patient_name_label.ForeColor = Color.White;
            Patient_name_label.Location = new Point(-1, 151);
            Patient_name_label.Margin = new Padding(4, 0, 4, 0);
            Patient_name_label.Name = "Patient_name_label";
            Patient_name_label.Padding = new Padding(162, 25, 0, 0);
            Patient_name_label.Size = new Size(407, 195);
            Patient_name_label.TabIndex = 6;
            Patient_name_label.Text = "Patient";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(16, 122, 84);
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(157, 282);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(182, 32);
            label5.TabIndex = 7;
            label5.Text = "Patient_Name";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.BackColor = Color.FromArgb(16, 122, 84);
            label2.Location = new Point(-1, 346);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 300);
            label2.Size = new Size(407, 1228);
            label2.TabIndex = 8;
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
            Tappbtn.Location = new Point(-1, 477);
            Tappbtn.Margin = new Padding(4, 3, 4, 3);
            Tappbtn.Name = "Tappbtn";
            Tappbtn.Size = new Size(407, 80);
            Tappbtn.TabIndex = 33;
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
            medicalhisBtn.Location = new Point(-1, 554);
            medicalhisBtn.Margin = new Padding(4, 3, 4, 3);
            medicalhisBtn.Name = "medicalhisBtn";
            medicalhisBtn.Size = new Size(407, 64);
            medicalhisBtn.TabIndex = 34;
            medicalhisBtn.Text = "Medical history";
            medicalhisBtn.UseVisualStyleBackColor = false;
            medicalhisBtn.Click += medicalhisBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(517, 228);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 36;
            label3.Text = "Name:  ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(896, 227);
            label6.Name = "label6";
            label6.Size = new Size(118, 26);
            label6.TabIndex = 37;
            label6.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(1324, 228);
            label7.Name = "label7";
            label7.Size = new Size(80, 26);
            label7.TabIndex = 38;
            label7.Text = "CNIC:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(506, 427);
            label8.Name = "label8";
            label8.Size = new Size(153, 26);
            label8.TabIndex = 39;
            label8.Text = "Blood Group:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(919, 427);
            label9.Name = "label9";
            label9.Size = new Size(81, 26);
            label9.TabIndex = 40;
            label9.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(1324, 426);
            label10.Name = "label10";
            label10.Size = new Size(97, 26);
            label10.TabIndex = 41;
            label10.Text = "Gender:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(517, 611);
            label11.Name = "label11";
            label11.Size = new Size(103, 26);
            label11.TabIndex = 42;
            label11.Text = "Address:";
            // 
            // Patient_Password
            // 
            Patient_Password.AutoSize = true;
            Patient_Password.ForeColor = Color.Black;
            Patient_Password.Location = new Point(1036, 227);
            Patient_Password.Name = "Patient_Password";
            Patient_Password.Size = new Size(181, 25);
            Patient_Password.TabIndex = 44;
            Patient_Password.Text = "Patient_Password";
            Patient_Password.Click += Patient_Password_Click;
            // 
            // Patient_CNIC
            // 
            Patient_CNIC.AutoSize = true;
            Patient_CNIC.ForeColor = Color.Black;
            Patient_CNIC.Location = new Point(1422, 227);
            Patient_CNIC.Name = "Patient_CNIC";
            Patient_CNIC.Size = new Size(147, 25);
            Patient_CNIC.TabIndex = 45;
            Patient_CNIC.Text = "Patient_CNIC";
            Patient_CNIC.Click += Patient_CNIC_Click;
            // 
            // Patient_BG
            // 
            Patient_BG.AutoSize = true;
            Patient_BG.ForeColor = Color.Black;
            Patient_BG.Location = new Point(705, 428);
            Patient_BG.Name = "Patient_BG";
            Patient_BG.Size = new Size(122, 25);
            Patient_BG.TabIndex = 46;
            Patient_BG.Text = "Patient_BG";
            Patient_BG.Click += Patient_BG_Click;
            // 
            // P_Email
            // 
            P_Email.AutoSize = true;
            P_Email.ForeColor = Color.Black;
            P_Email.Location = new Point(1036, 427);
            P_Email.Name = "P_Email";
            P_Email.Size = new Size(93, 25);
            P_Email.TabIndex = 47;
            P_Email.Text = "P_Email";
            P_Email.Click += P_Email_Click;
            // 
            // P_Gender
            // 
            P_Gender.AutoSize = true;
            P_Gender.ForeColor = Color.Black;
            P_Gender.Location = new Point(1443, 428);
            P_Gender.Name = "P_Gender";
            P_Gender.Size = new Size(107, 25);
            P_Gender.TabIndex = 48;
            P_Gender.Text = "P_Gender";
            P_Gender.Click += P_Gender_Click;
            // 
            // P_Address
            // 
            P_Address.AutoSize = true;
            P_Address.ForeColor = Color.Black;
            P_Address.Location = new Point(671, 611);
            P_Address.Name = "P_Address";
            P_Address.Size = new Size(113, 25);
            P_Address.TabIndex = 49;
            P_Address.Text = "P_Address";
            P_Address.Click += P_Address_Click;
            // 
            // oracleCommand1
            // 
            oracleCommand1.Transaction = null;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label12.BackColor = Color.FromArgb(16, 122, 84);
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Location = new Point(405, 287);
            label12.Name = "label12";
            label12.Size = new Size(1211, 3);
            label12.TabIndex = 50;
            label12.Text = "label12";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label14.BackColor = Color.FromArgb(16, 122, 84);
            label14.BorderStyle = BorderStyle.Fixed3D;
            label14.Location = new Point(405, 471);
            label14.Name = "label14";
            label14.Size = new Size(1198, 3);
            label14.TabIndex = 52;
            label14.Text = "label14";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label16.BorderStyle = BorderStyle.Fixed3D;
            label16.Location = new Point(405, 657);
            label16.Name = "label16";
            label16.Size = new Size(1198, 3);
            label16.TabIndex = 54;
            label16.Text = "label16";
            // 
            // Patient_Name
            // 
            Patient_Name.ForeColor = Color.Black;
            Patient_Name.Location = new Point(639, 229);
            Patient_Name.Name = "Patient_Name";
            Patient_Name.Size = new Size(163, 25);
            Patient_Name.TabIndex = 56;
            Patient_Name.Text = "Patient_Name";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(232, 232, 232);
            button5.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            button5.FlatAppearance.BorderSize = 3;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(16, 122, 84);
            button5.Location = new Point(-1, 611);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(407, 68);
            button5.TabIndex = 35;
            button5.Text = "Receptionists";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // logoutbtn
            // 
            logoutbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logoutbtn.BackColor = Color.FromArgb(16, 122, 84);
            logoutbtn.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            logoutbtn.ForeColor = Color.White;
            logoutbtn.Location = new Point(1483, 11);
            logoutbtn.Margin = new Padding(4, 2, 4, 2);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(133, 55);
            logoutbtn.TabIndex = 57;
            logoutbtn.Text = "LOG OUT";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // label15
            // 
            label15.BorderStyle = BorderStyle.Fixed3D;
            label15.Location = new Point(418, 126);
            label15.Name = "label15";
            label15.Size = new Size(231, 3);
            label15.TabIndex = 53;
            label15.Text = "label15";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(413, 94);
            label13.Name = "label13";
            label13.Size = new Size(236, 32);
            label13.TabIndex = 51;
            label13.Text = "Detail Information";
            // 
            // Patient_View
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1626, 775);
            Controls.Add(logoutbtn);
            Controls.Add(Patient_Name);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(P_Address);
            Controls.Add(P_Gender);
            Controls.Add(P_Email);
            Controls.Add(Patient_BG);
            Controls.Add(Patient_CNIC);
            Controls.Add(Patient_Password);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(medicalhisBtn);
            Controls.Add(Tappbtn);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(Patient_name_label);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Patient_View";
            Text = "Patient_View";
            Load += Patient_View_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label Patient_name_label;
        private Label label5;
        private Label label2;
        private Button Tappbtn;
        private Button medicalhisBtn;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label Patient_Password;
        private Label Patient_CNIC;
        private Label Patient_BG;
        private Label P_Email;
        private Label P_Gender;
        private Label P_Address;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private Label label12;
        private Label label14;
        private Label label16;
        private Label Patient_Name;
        private Button button5;
        private Button logoutbtn;
        private Label label15;
        private Label label13;
    }
}