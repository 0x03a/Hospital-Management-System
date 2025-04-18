namespace WinFormsApp5
{
    partial class Total_Appointments_IN_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Total_Appointments_IN_Admin));
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label4 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            logout = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(16, 122, 84);
            label3.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(-3, 158);
            label3.Name = "label3";
            label3.Padding = new Padding(125, 75, 0, 0);
            label3.Size = new Size(313, 195);
            label3.TabIndex = 6;
            label3.Text = "Admin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(16, 122, 84);
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(114, 265);
            label5.Name = "label5";
            label5.Size = new Size(89, 32);
            label5.TabIndex = 7;
            label5.Text = "Inshal";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.BackColor = Color.FromArgb(16, 122, 84);
            label2.Location = new Point(1, 353);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 300);
            label2.Size = new Size(313, 1000);
            label2.TabIndex = 8;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(232, 232, 232);
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(-3, 371);
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
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(-3, 433);
            button2.Name = "button2";
            button2.Size = new Size(313, 69);
            button2.TabIndex = 32;
            button2.Text = "Patients";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(232, 232, 232);
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(-3, 495);
            button3.Name = "button3";
            button3.Size = new Size(313, 80);
            button3.TabIndex = 33;
            button3.Text = "Total Apointments";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(232, 232, 232);
            button4.FlatAppearance.BorderColor = Color.Green;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(-3, 568);
            button4.Name = "button4";
            button4.Size = new Size(313, 64);
            button4.TabIndex = 34;
            button4.Text = "Nurses";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderColor = Color.Green;
            button5.FlatAppearance.BorderSize = 3;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(-3, 626);
            button5.Name = "button5";
            button5.Size = new Size(313, 68);
            button5.TabIndex = 35;
            button5.Text = "Receptionists";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(329, 158);
            label1.Name = "label1";
            label1.Size = new Size(368, 36);
            label1.TabIndex = 49;
            label1.Text = "Total Appointments Table";
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.None;
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.FromArgb(232, 232, 232);
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(44, 125, 147);
            label4.Location = new Point(1, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(320, 40, 0, 0);
            label4.Size = new Size(1908, 125);
            label4.TabIndex = 50;
            label4.Text = "HOSPITAL MANAGEMENT ";
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(16, 122, 84);
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(-3, 0);
            label6.Name = "label6";
            label6.Size = new Size(313, 184);
            label6.TabIndex = 51;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(337, 249);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(823, 342);
            dataGridView1.TabIndex = 52;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout.BackColor = Color.FromArgb(16, 122, 84);
            logout.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            logout.FlatAppearance.BorderSize = 3;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logout.ForeColor = Color.FromArgb(232, 232, 232);
            logout.Location = new Point(1061, 23);
            logout.Name = "logout";
            logout.Padding = new Padding(7, 13, 25, 0);
            logout.Size = new Size(181, 64);
            logout.TabIndex = 53;
            logout.Text = "LOG OUT";
            logout.TextAlign = ContentAlignment.TopRight;
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // Total_Appointments_IN_Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 868);
            Controls.Add(logout);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
            Name = "Total_Appointments_IN_Admin";
            Padding = new Padding(4, 0, 50, 0);
            Text = "Total_Appointments_IN_Admin";
            Load += Total_Appointments_IN_Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label5;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label4;
        private Label label6;
        private DataGridView dataGridView1;
        private Button logout;
    }
}