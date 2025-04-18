namespace WinFormsApp5
{
    partial class Receptionist_In_Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist_In_Patient));
            label2 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label1 = new Label();
            label4 = new Label();
            Patient_name_label = new Label();
            Tappbtn = new Button();
            medicalhisBtn = new Button();
            button5 = new Button();
            label6 = new Label();
            panel2 = new Panel();
            appoint_bnt = new Button();
            textBox1 = new TextBox();
            logoutbtn = new Button();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.BackColor = Color.FromArgb(16, 122, 84);
            label2.Location = new Point(1, 341);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 300);
            label2.Size = new Size(407, 1595);
            label2.TabIndex = 9;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Location = new Point(415, 372);
            panel1.Name = "panel1";
            panel1.Size = new Size(1178, 223);
            panel1.TabIndex = 37;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(235, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(903, 78);
            dataGridView1.TabIndex = 41;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(35, 129);
            label5.Name = "label5";
            label5.Size = new Size(181, 26);
            label5.TabIndex = 40;
            label5.Text = "Doctor Schedule";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 61);
            label3.Name = "label3";
            label3.Size = new Size(150, 26);
            label3.TabIndex = 39;
            label3.Text = "Select Doctor";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(235, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(272, 33);
            comboBox1.TabIndex = 38;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(531, 53);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(93, 14);
            label7.Name = "label7";
            label7.Size = new Size(102, 32);
            label7.TabIndex = 0;
            label7.Text = "Disease";
            label7.Click += label7_Click_1;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(232, 232, 232);
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(44, 125, 147);
            label1.Location = new Point(1, -2);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(416, 25, 0, 0);
            label1.Size = new Size(2207, 80);
            label1.TabIndex = 40;
            label1.Text = "HOSPITAL MANAGEMENT ";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(16, 122, 84);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(1, -2);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(407, 184);
            label4.TabIndex = 41;
            // 
            // Patient_name_label
            // 
            Patient_name_label.BackColor = Color.FromArgb(16, 122, 84);
            Patient_name_label.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Patient_name_label.ForeColor = Color.White;
            Patient_name_label.Location = new Point(1, 182);
            Patient_name_label.Margin = new Padding(4, 0, 4, 0);
            Patient_name_label.Name = "Patient_name_label";
            Patient_name_label.Padding = new Padding(162, 25, 0, 0);
            Patient_name_label.Size = new Size(407, 195);
            Patient_name_label.TabIndex = 42;
            Patient_name_label.Text = "Patient";
            Patient_name_label.Click += Patient_name_label_Click;
            // 
            // Tappbtn
            // 
            Tappbtn.BackColor = Color.FromArgb(232, 232, 232);
            Tappbtn.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            Tappbtn.FlatAppearance.BorderSize = 3;
            Tappbtn.FlatStyle = FlatStyle.Flat;
            Tappbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Tappbtn.ForeColor = Color.FromArgb(16, 122, 84);
            Tappbtn.Location = new Point(1, 427);
            Tappbtn.Margin = new Padding(4, 3, 4, 3);
            Tappbtn.Name = "Tappbtn";
            Tappbtn.Size = new Size(407, 80);
            Tappbtn.TabIndex = 43;
            Tappbtn.Text = "Total Apointments";
            Tappbtn.UseVisualStyleBackColor = false;
            Tappbtn.Click += Tappbtn_Click_1;
            // 
            // medicalhisBtn
            // 
            medicalhisBtn.BackColor = Color.FromArgb(232, 232, 232);
            medicalhisBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            medicalhisBtn.FlatAppearance.BorderSize = 3;
            medicalhisBtn.FlatStyle = FlatStyle.Flat;
            medicalhisBtn.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            medicalhisBtn.ForeColor = Color.FromArgb(16, 122, 84);
            medicalhisBtn.Location = new Point(1, 501);
            medicalhisBtn.Margin = new Padding(4, 3, 4, 3);
            medicalhisBtn.Name = "medicalhisBtn";
            medicalhisBtn.Size = new Size(407, 64);
            medicalhisBtn.TabIndex = 44;
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
            button5.Location = new Point(1, 558);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(407, 68);
            button5.TabIndex = 45;
            button5.Text = "Receptionists";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(469, 220);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 46;
            label6.Text = "label6";
            // 
            // panel2
            // 
            panel2.Controls.Add(appoint_bnt);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label7);
            panel2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(627, 601);
            panel2.Name = "panel2";
            panel2.Size = new Size(655, 399);
            panel2.TabIndex = 47;
            panel2.Paint += panel2_Paint;
            // 
            // appoint_bnt
            // 
            appoint_bnt.BackColor = Color.FromArgb(16, 122, 84);
            appoint_bnt.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            appoint_bnt.FlatAppearance.BorderSize = 3;
            appoint_bnt.FlatStyle = FlatStyle.Flat;
            appoint_bnt.ForeColor = Color.White;
            appoint_bnt.Location = new Point(301, 271);
            appoint_bnt.Name = "appoint_bnt";
            appoint_bnt.Size = new Size(160, 55);
            appoint_bnt.TabIndex = 48;
            appoint_bnt.Text = "Appoint";
            appoint_bnt.UseVisualStyleBackColor = false;
            appoint_bnt.Click += appoint_bnt_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(161, 49);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(440, 207);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // logoutbtn
            // 
            logoutbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logoutbtn.BackColor = Color.FromArgb(16, 122, 84);
            logoutbtn.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            logoutbtn.ForeColor = Color.White;
            logoutbtn.Location = new Point(1447, 11);
            logoutbtn.Margin = new Padding(4, 2, 4, 2);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(133, 55);
            logoutbtn.TabIndex = 58;
            logoutbtn.Text = "LOG OUT";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(16, 122, 84);
            label8.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(157, 274);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(182, 32);
            label8.TabIndex = 59;
            label8.Text = "Patient_Name";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(450, 146);
            label9.Name = "label9";
            label9.Size = new Size(269, 36);
            label9.TabIndex = 60;
            label9.Text = "Take Appointment";
            // 
            // Receptionist_In_Patient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1582, 1050);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(logoutbtn);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(button5);
            Controls.Add(medicalhisBtn);
            Controls.Add(Tappbtn);
            Controls.Add(Patient_name_label);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "Receptionist_In_Patient";
            Text = "Receptionist_In_Patient";
            Load += Receptionist_In_Patient_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Panel panel1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label Patient_name_label;
        private Button Tappbtn;
        private Button medicalhisBtn;
        private Button button5;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label6;
        private Panel panel2;
        private TextBox textBox1;
        private Label label7;
        private Button appoint_bnt;
        private Button logoutbtn;
        private Label label8;
        private Label label9;
    }
}