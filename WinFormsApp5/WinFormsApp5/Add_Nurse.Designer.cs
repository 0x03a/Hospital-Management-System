namespace WinFormsApp5
{
    partial class Add_Nurse
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Nurse));
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            button1 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button3 = new Button();
            button9 = new Button();
            textBox1 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            label11 = new Label();
            label8 = new Label();
            textBox3 = new TextBox();
            comboBox2 = new ComboBox();
            label10 = new Label();
            textBox4 = new TextBox();
            label12 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button10 = new Button();
            button4 = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(232, 232, 232);
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(44, 125, 147);
            label1.Location = new Point(0, -2);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(350, 25, 0, 0);
            label1.Size = new Size(2818, 80);
            label1.TabIndex = 3;
            label1.Text = "HOSPITAL MANAGEMENT ";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(16, 122, 84);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(0, -2);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(315, 184);
            label4.TabIndex = 7;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(16, 122, 84);
            label3.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(0, 155);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(130, 25, 0, 0);
            label3.Size = new Size(315, 181);
            label3.TabIndex = 8;
            label3.Text = "Admin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(16, 122, 84);
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(119, 277);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 32);
            label5.TabIndex = 9;
            label5.Text = "Inshal";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.BackColor = Color.FromArgb(16, 122, 84);
            label2.Location = new Point(0, 336);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 300);
            label2.Size = new Size(315, 1258);
            label2.TabIndex = 10;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(232, 232, 232);
            button1.FlatAppearance.BorderColor = Color.FromArgb(16, 122, 84);
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(0, 390);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(314, 92);
            button1.TabIndex = 11;
            button1.Text = "Doctors";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(232, 232, 232);
            button6.FlatAppearance.BorderColor = Color.FromArgb(16, 122, 84);
            button6.FlatAppearance.BorderSize = 3;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(-1, 477);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(315, 92);
            button6.TabIndex = 17;
            button6.Text = "Patients";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(232, 232, 232);
            button7.FlatAppearance.BorderColor = Color.FromArgb(16, 122, 84);
            button7.FlatAppearance.BorderSize = 3;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(-1, 568);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(315, 92);
            button7.TabIndex = 18;
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
            button8.Location = new Point(-1, 657);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(315, 92);
            button8.TabIndex = 19;
            button8.Text = "Nurses";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(232, 232, 232);
            button3.FlatAppearance.BorderColor = Color.FromArgb(16, 122, 84);
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(0, 745);
            button3.Margin = new Padding(4, 2, 4, 2);
            button3.Name = "button3";
            button3.Size = new Size(315, 47);
            button3.TabIndex = 20;
            button3.Text = "Add Nurse";
            button3.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(232, 232, 232);
            button9.FlatAppearance.BorderColor = Color.FromArgb(16, 122, 84);
            button9.FlatAppearance.BorderSize = 3;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(2, 788);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(313, 92);
            button9.TabIndex = 22;
            button9.Text = "Receptionists";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(688, 228);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 31);
            textBox1.TabIndex = 31;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Validating += textBox1_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(485, 234);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 32;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(485, 330);
            label7.Name = "label7";
            label7.Size = new Size(103, 25);
            label7.TabIndex = 33;
            label7.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(688, 324);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 31);
            textBox2.TabIndex = 34;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Validating += textBox2_Validating;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(485, 568);
            label11.Name = "label11";
            label11.Size = new Size(71, 25);
            label11.TabIndex = 35;
            label11.Text = "Salary";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(485, 414);
            label8.Name = "label8";
            label8.Size = new Size(68, 25);
            label8.TabIndex = 36;
            label8.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(688, 408);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 31);
            textBox3.TabIndex = 37;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.Validating += textBox3_Validating;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Bachelor of Science in Nursing (BSN)", "Associate Degree in Nursing (ADN)", "Licensed Practical Nurse (LPN)", "Registered Nurse (RN)", "Master of Science in Nursing (MSN)", "Doctor of Nursing Practice (DNP)", "Certified Registered Nurse Anesthetist (CRNA)", "Certified Nurse Midwife (CNM)", "Clinical Nurse Specialist (CNS)", "Nurse Practitioner (NP)" });
            comboBox2.Location = new Point(688, 488);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(282, 33);
            comboBox2.TabIndex = 38;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBox2.Validating += comboBox2_Validating;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(485, 496);
            label10.Name = "label10";
            label10.Size = new Size(134, 25);
            label10.TabIndex = 39;
            label10.Text = "Qualification";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(688, 562);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 31);
            textBox4.TabIndex = 40;
            textBox4.TextChanged += textBox4_TextChanged;
            textBox4.Validating += textBox4_Validating;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(485, 634);
            label12.Name = "label12";
            label12.Size = new Size(90, 26);
            label12.TabIndex = 41;
            label12.Text = "Gender";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(688, 631);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(76, 29);
            checkBox1.TabIndex = 42;
            checkBox1.Text = "Male";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(806, 631);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(94, 29);
            checkBox2.TabIndex = 43;
            checkBox2.Text = "Female";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.Highlight;
            button10.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(688, 730);
            button10.Name = "button10";
            button10.Size = new Size(150, 52);
            button10.TabIndex = 44;
            button10.Text = "INSERT";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(16, 122, 84);
            button4.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(996, 11);
            button4.Margin = new Padding(4, 2, 4, 2);
            button4.Name = "button4";
            button4.Size = new Size(133, 55);
            button4.TabIndex = 45;
            button4.Text = "LOG OUT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            errorProvider5.ContainerControl = this;
            // 
            // Add_Nurse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 820);
            Controls.Add(button4);
            Controls.Add(button10);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label12);
            Controls.Add(textBox4);
            Controls.Add(label10);
            Controls.Add(comboBox2);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(button9);
            Controls.Add(button3);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Add_Nurse";
            Text = "Add_Nurse";
            Load += Add_Nurse_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
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
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button3;
        private Button button9;
        private TextBox textBox1;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private Label label11;
        private Label label8;
        private TextBox textBox3;
        private ComboBox comboBox2;
        private Label label10;
        private TextBox textBox4;
        private Label label12;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button10;
        private Button button4;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
    }
}