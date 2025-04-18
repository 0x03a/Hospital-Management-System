namespace WinFormsApp5
{
    partial class Patient_sign
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            txtEmail = new TextBox();
            textBox7 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            maskedTextBox2 = new MaskedTextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox3 = new TextBox();
            INSERTbutton = new Button();
            btnsend = new Button();
            Verifybtn = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button4 = new Button();
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
            label1.Cursor = Cursors.AppStarting;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(44, 125, 147);
            label1.Location = new Point(2, -1);
            label1.Name = "label1";
            label1.Padding = new Padding(190, 50, 199, 50);
            label1.Size = new Size(1835, 145);
            label1.TabIndex = 1;
            label1.Text = "LET US KNOW YOUR INFORMATION";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(208, 220);
            label2.Name = "label2";
            label2.Size = new Size(71, 26);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(208, 289);
            label3.Name = "label3";
            label3.Size = new Size(110, 26);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(208, 368);
            label4.Name = "label4";
            label4.Size = new Size(72, 26);
            label4.TabIndex = 4;
            label4.Text = "CNIC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(208, 443);
            label5.Name = "label5";
            label5.Size = new Size(145, 26);
            label5.TabIndex = 5;
            label5.Text = "Blood Group";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(208, 508);
            label6.Name = "label6";
            label6.Size = new Size(73, 26);
            label6.TabIndex = 6;
            label6.Text = "Email";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(208, 568);
            label7.Name = "label7";
            label7.Size = new Size(89, 26);
            label7.TabIndex = 7;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(208, 635);
            label8.Name = "label8";
            label8.Size = new Size(95, 26);
            label8.TabIndex = 8;
            label8.Text = "Address";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(492, 215);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Validating += textBox1_Validating;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(492, 284);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Validating += textBox2_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(492, 503);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 13;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.Location = new Point(492, 633);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 31);
            textBox7.TabIndex = 15;
            textBox7.TextChanged += textBox7_TextChanged;
            textBox7.Validating += textBox7_Validating;
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
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(490, 363);
            maskedTextBox2.Mask = "00000-00000000-0";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(150, 31);
            maskedTextBox2.TabIndex = 28;
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            maskedTextBox2.Validating += maskedTextBox2_Validating;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(490, 442);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 29);
            radioButton1.TabIndex = 29;
            radioButton1.TabStop = true;
            radioButton1.Text = "O+";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(561, 443);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(58, 29);
            radioButton2.TabIndex = 30;
            radioButton2.TabStop = true;
            radioButton2.Text = "O-";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(638, 443);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(71, 29);
            radioButton3.TabIndex = 31;
            radioButton3.TabStop = true;
            radioButton3.Text = "AB+";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(727, 443);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(66, 29);
            radioButton4.TabIndex = 32;
            radioButton4.TabStop = true;
            radioButton4.Text = "AB-";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(799, 443);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(61, 29);
            radioButton5.TabIndex = 33;
            radioButton5.TabStop = true;
            radioButton5.Text = "A+";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(866, 443);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(56, 29);
            radioButton6.TabIndex = 34;
            radioButton6.TabStop = true;
            radioButton6.Text = "A-";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(928, 443);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(59, 29);
            radioButton7.TabIndex = 35;
            radioButton7.TabStop = true;
            radioButton7.Text = "B+";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(993, 443);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(54, 29);
            radioButton8.TabIndex = 36;
            radioButton8.TabStop = true;
            radioButton8.Text = "B-";
            radioButton8.UseVisualStyleBackColor = true;
            radioButton8.CheckedChanged += radioButton8_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(208, 716);
            label9.Name = "label9";
            label9.Size = new Size(74, 26);
            label9.TabIndex = 40;
            label9.Text = "Note: ";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(279, 722);
            label10.Name = "label10";
            label10.Size = new Size(593, 20);
            label10.TabIndex = 41;
            label10.Text = "An OTP will be send on your Email, please enter it to get the insert button. ";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(208, 777);
            label11.Name = "label11";
            label11.Size = new Size(61, 26);
            label11.TabIndex = 42;
            label11.Text = "OTP";
            label11.Click += label11_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(492, 772);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 43;
            textBox3.TextChanged += textBox3_TextChanged_1;
            // 
            // INSERTbutton
            // 
            INSERTbutton.BackColor = SystemColors.Highlight;
            INSERTbutton.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            INSERTbutton.Location = new Point(507, 708);
            INSERTbutton.Name = "INSERTbutton";
            INSERTbutton.Size = new Size(130, 48);
            INSERTbutton.TabIndex = 44;
            INSERTbutton.Text = "Register";
            INSERTbutton.UseVisualStyleBackColor = false;
            INSERTbutton.Click += INSERTbutton_Click;
            // 
            // btnsend
            // 
            btnsend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnsend.Location = new Point(666, 769);
            btnsend.Name = "btnsend";
            btnsend.Size = new Size(112, 34);
            btnsend.TabIndex = 46;
            btnsend.Text = "SEND";
            btnsend.UseVisualStyleBackColor = true;
            btnsend.Click += btnsend_Click;
            // 
            // Verifybtn
            // 
            Verifybtn.Location = new Point(525, 825);
            Verifybtn.Name = "Verifybtn";
            Verifybtn.Size = new Size(112, 34);
            Verifybtn.TabIndex = 48;
            Verifybtn.Text = "Verify";
            Verifybtn.UseVisualStyleBackColor = true;
            Verifybtn.Click += Verifybtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(492, 568);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(76, 29);
            checkBox1.TabIndex = 49;
            checkBox1.Text = "Male";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(587, 568);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(94, 29);
            checkBox2.TabIndex = 50;
            checkBox2.Text = "Female";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(16, 122, 84);
            button4.FlatAppearance.BorderColor = Color.FromArgb(16, 122, 84);
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1274, 32);
            button4.Margin = new Padding(4, 2, 4, 2);
            button4.Name = "button4";
            button4.Size = new Size(133, 55);
            button4.TabIndex = 51;
            button4.Text = "LOG OUT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Patient_sign
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1411, 974);
            Controls.Add(button4);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(Verifybtn);
            Controls.Add(btnsend);
            Controls.Add(INSERTbutton);
            Controls.Add(textBox3);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(radioButton8);
            Controls.Add(radioButton7);
            Controls.Add(radioButton6);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(maskedTextBox2);
            Controls.Add(textBox7);
            Controls.Add(txtEmail);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Patient_sign";
            Text = "Patient_sign";
            Load += Patient_sign_Load;
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtEmail;
        private TextBox textBox7;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
        private MaskedTextBox maskedTextBox2;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label9;
        private Label label10;
        private TextBox textBox3;
        private Label label11;
        private Button INSERTbutton;
        private Button btnsend;
        private Button Verifybtn;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button4;
    }
}