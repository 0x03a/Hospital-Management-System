using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        OracleConnection con;

        private string name = "Inshal";
        private string Password = "DB123";
        private string name1 = "";// for patient_name, doctor_name, nurse_name, receptionist _name
        private string Password1 = "";// for patient_ID, doctor_ID, nurse_ID, receptionist _ID
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }


        //.........I have maiximize the label1 just by doing autoize = False , and when i maximize the form it is automatically adjusted
        private void Form1_Load(object sender, EventArgs e)
        {
            string con1Str = @"DATA SOURCE=localhost:1521/XE;USER ID=INSHALLL;PASSWORD=progr@mmer";
            con = new OracleConnection(con1Str);
            





                         panel1.BackColor = Color.FromArgb(150, 255, 255, 255); // Semi-transparent white (R: 255, G: 255, B: 255)

         


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            // if characters bring them back to *
            if (textBox2.PasswordChar == '\0')
            {
                button2.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // if * bring them back to characters
            if (textBox2.PasswordChar == '*')
            {
                button1.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // hide form1
            this.Hide();
            // Show form3
            Patient_sign form1 = new Patient_sign();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();





        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true && string.IsNullOrEmpty(textBox2.Text) == true) // if both empty and you are trying to login show this
            {
                MessageBox.Show("Enter the data first in both Name and Password");
            }
            else if (string.IsNullOrEmpty(textBox1.Text) == true) // if naem empty and you are trying to login show this
            {
                MessageBox.Show(textBox1.Text, "Please Enter The Name");
            }
            else if (string.IsNullOrEmpty(textBox2.Text) == true) // if Password empty and you are trying to login show this
            {
                MessageBox.Show(textBox2.Text, "Please Enter The Password");
            }
            else
            {

                bool flag_check_Others = true;


                if (textBox1.Text == name && textBox2.Text == Password)
                {
                    MessageBox.Show("Admin Login Successfully");
                    this.Hide();
                    Form2 admin_Page = new Form2();
                    admin_Page.Closed += (s, args) => this.Close();
                    admin_Page.Show();
                }
                else if (flag_check_Others)
                {
                    con.Open();
                    OracleCommand command = con.CreateCommand();
                    command.CommandText = "SELECT Name, Password FROM PATIENT WHERE Name = :name AND Password = :password";
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add(new OracleParameter("name", textBox1.Text));
                    command.Parameters.Add(new OracleParameter("password", textBox2.Text));

                    // Execute the command
                    OracleDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // If a row is returned, the username and password are correct
                        name1 = reader["Name"].ToString();
                        Password1 = reader["Password"].ToString();

                        // Do something with the name and password
                    }


                    // Close the reader and connection
                    reader.Close();
                    con.Close();

                    if (textBox1.Text == name1 && textBox2.Text == Password1)
                    {
                        con.Close();
                        MessageBox.Show("Patient Login Successfully");
                        this.Hide();
                        Patient_View form = new Patient_View(name1, Password1);
                        form.Closed += (s, args) => form.Close();
                        form.Show();
                        return;

                    }
                    name1 = "";
                    Password1 = "";


                    con.Open();
                    OracleCommand command1 = con.CreateCommand();
                    command1.CommandText = "SELECT Name, Password FROM DOCTORS WHERE Name = :name AND Password = :password";
                    command1.CommandType = CommandType.Text;
                    command1.Parameters.Add(new OracleParameter("name", textBox1.Text));
                    command1.Parameters.Add(new OracleParameter("password", textBox2.Text));

                    // Execute the command
                    OracleDataReader reader1 = command1.ExecuteReader();

                    if (reader1.Read())
                    {
                        // If a row is returned, the username and password are correct
                        name1 = reader1["Name"].ToString();
                        Password1 = reader1["Password"].ToString();

                        // Do something with the name and password
                    }


                    // Close the reader and connection
                    reader1.Close();
                    con.Close();


                    if (textBox1.Text == name1 && textBox2.Text == Password1)
                    {
                        con.Close();
                        MessageBox.Show(" Doctor Login Successfully");
                        this.Hide();
                        Doctor_view form = new Doctor_view(name1, Password1);
                        form.Closed += (s, args) => form.Close();
                        form.Show();
                        return;

                    }
                    name1 = "";
                    Password1 = "";

                    if (textBox1.Text != name1 || textBox2.Text != Password1)
                    {
                        MessageBox.Show("Please enter a different value for the above field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();

                        return;

                    }




                }

                else if (textBox1.Text == name && textBox2.Text != Password)
                {
                    MessageBox.Show("Incorrect  Password");
                }
                else if (textBox1.Text != name)
                {
                    MessageBox.Show("Incorrect  User Name");
                }
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            // if empty show error
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {

                errorProvider1.SetError(textBox1, "Please Enter the Name");
            }
            else
                errorProvider1.SetError(textBox1, string.Empty); // else clear the error 
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {


            // if empty show error
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {

                errorProvider2.SetError(textBox2, "Please Enter The Passwrd");
            }
            else
            {
                errorProvider2.SetError(textBox2, string.Empty); // else clear the error 
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}