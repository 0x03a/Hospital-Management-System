namespace WinFormsApp5
{
    partial class Nurse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nurse));
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
            dataGridView1 = new DataGridView();
            button4 = new Button();
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
            label1.Location = new Point(2, -1);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(416, 25, 0, 0);
            label1.Size = new Size(2838, 80);
            label1.TabIndex = 3;
            label1.Text = "HOSPITAL MANAGEMENT ";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(16, 122, 84);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(2, -1);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(315, 184);
            label4.TabIndex = 6;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(16, 122, 84);
            label3.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(2, 156);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(130, 25, 0, 0);
            label3.Size = new Size(315, 181);
            label3.TabIndex = 7;
            label3.Text = "Admin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(16, 122, 84);
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(117, 277);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 32);
            label5.TabIndex = 8;
            label5.Text = "Inshal";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.BackColor = Color.FromArgb(16, 122, 84);
            label2.Location = new Point(2, 337);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 300);
            label2.Size = new Size(315, 1337);
            label2.TabIndex = 9;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(232, 232, 232);
            button1.FlatAppearance.BorderColor = Color.FromArgb(16, 122, 84);
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(3, 428);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(314, 92);
            button1.TabIndex = 10;
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
            button6.Location = new Point(2, 517);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(315, 92);
            button6.TabIndex = 16;
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
            button7.Location = new Point(2, 607);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(315, 92);
            button7.TabIndex = 17;
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
            button8.Location = new Point(3, 697);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(315, 92);
            button8.TabIndex = 18;
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
            button3.Location = new Point(2, 785);
            button3.Margin = new Padding(4, 2, 4, 2);
            button3.Name = "button3";
            button3.Size = new Size(315, 47);
            button3.TabIndex = 19;
            button3.Text = "Add Nurse";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(232, 232, 232);
            button9.FlatAppearance.BorderColor = Color.FromArgb(16, 122, 84);
            button9.FlatAppearance.BorderSize = 3;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(3, 828);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(313, 92);
            button9.TabIndex = 21;
            button9.Text = "Receptionists";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(391, 244);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1056, 401);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(16, 122, 84);
            button4.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1323, 11);
            button4.Margin = new Padding(4, 2, 4, 2);
            button4.Name = "button4";
            button4.Size = new Size(133, 55);
            button4.TabIndex = 23;
            button4.Text = "LOG OUT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(391, 183);
            label6.Name = "label6";
            label6.Size = new Size(165, 25);
            label6.TabIndex = 40;
            label6.Text = "NURSE TABLE";
            // 
            // Nurse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 1046);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
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
            Name = "Nurse";
            Text = "Nurse";
            Load += Nurse_Load;
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
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button3;
        private Button button9;
        private DataGridView dataGridView1;
        private Button button4;
        private Label label6;
    }
}