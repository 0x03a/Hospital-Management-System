using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ax.DataAccess;
using Oracle.ManagedDataAccess.Client;
namespace WinFormsApp5
{
    public partial class Receptionist_add : Form
    {
        OracleConnection con9;
        public Receptionist_add()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Doctors Button
            // Go to the Doctor page
            this.Hide();
            Doctor form = new Doctor();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void Receptionist_add_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=INSHALLL;PASSWORD=progr@mmer";
            con9 = new OracleConnection(conStr);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Patient Button
            // Go to the Patient page

            this.Hide();

            PatientinAdmin form = new PatientinAdmin();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Appointment button
            // Go to the Appointpage page
            this.Hide();
            Total_Appointments_IN_Admin form1 = new Total_Appointments_IN_Admin();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            // Nurse Button
            // Go to the Nurse page
            this.Hide();
            Nurse form = new Nurse();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Receptionist Button
            // Go to the RECEPTIONIST page
            this.Hide();
            Receptionist form = new Receptionist();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Update receptionist Button
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Name text_box
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Password text_Box
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Email textbox
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Qualification Combo Box

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Salary TextBox
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // if Male is Selected You cannot select Female
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
            else
                checkBox2.Checked = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // if Female is Selected You cannot select male
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
            else
                checkBox1.Checked = true;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            // if empty show error
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {

                errorProvider1.SetError(textBox1, "Please Enter the Receptionist Name");

            }
            else
            {

                errorProvider1.SetError(textBox3, string.Empty); // else clear the error 

            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            // if empty show error
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {

                errorProvider2.SetError(textBox2, "Please Enter the Recepionist Password");

            }
            else
            {

                errorProvider2.SetError(textBox2, string.Empty); // else clear the error 

            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            // if empty show error
            if (string.IsNullOrEmpty(textBox3.Text) == true)
            {

                errorProvider3.SetError(textBox3, "Please Enter the Email");

            }
            else
            {

                errorProvider3.SetError(textBox3, string.Empty); // else clear the error 

            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            // if empty show error
            if (string.IsNullOrEmpty(textBox4.Text) == true)
            {

                errorProvider4.SetError(textBox4, "Please Enter the Salary");

            }
            else
            {

                errorProvider4.SetError(textBox4, string.Empty); // else clear the error 

            }
        }


        // Checking that emial is valid or not
        private static bool IsValid(string email)
        {
            try
            {
                var emailAddress = new MailAddress(email);
                return true; // Email address is valid
            }
            catch (FormatException)
            {
                return false; // Invalid email address format
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Insert button 

            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                MessageBox.Show("Name is Empty");
            }
            else if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                MessageBox.Show("Password is Empty");

            }
            else if (string.IsNullOrEmpty(textBox3.Text) == true)
            {
                MessageBox.Show("Email is Empty");
            }
            else if (string.IsNullOrEmpty(textBox4.Text) == true)
            {
                MessageBox.Show("Salary is Empty");
            }
            else if (string.IsNullOrEmpty(comboBox2.Text) == true)
            {
                MessageBox.Show("Qualification is missing");
            }
            string Gender = "";

            if (checkBox1.Checked == true)
            {
                Gender = checkBox1.Text.ToString();
            }
            else if (checkBox2.Checked == true) { }
            {
                Gender = checkBox2.Text.ToString();
            }




            if (string.IsNullOrEmpty(textBox3.Text) != true && !IsValid(textBox3.Text))
            {
                MessageBox.Show("Email is Invalid");
                return;

            }


            if ((string.IsNullOrEmpty(textBox1.Text) != true) && (string.IsNullOrEmpty(textBox2.Text)) != true && string.IsNullOrEmpty(textBox3.Text) != true && IsValid(textBox3.Text) && string.IsNullOrEmpty(textBox4.Text) != true && (checkBox1.Checked == true || checkBox2.Checked == true) && string.IsNullOrEmpty(comboBox2.Text) != true)
            {

                try
                {
                    con9.Open();

                    // Check if receptionist with the same name already exists
                    OracleCommand cmdCheckDuplicate = con9.CreateCommand();
                    cmdCheckDuplicate.CommandText = "SELECT COUNT(*) FROM RECEPTIONIST WHERE UPPER(Name) = UPPER(:Name)";
                    cmdCheckDuplicate.Parameters.Add(":Name", OracleDbType.Varchar2).Value = textBox1.Text.Trim().ToUpper(); // Convert to uppercase for case-insensitive comparison

                    int existingCount = Convert.ToInt32(cmdCheckDuplicate.ExecuteScalar());

                    if (existingCount == 0)
                    {
                        // No receptionist with the same name exists, proceed with insertion
                        OracleCommand insertingEmp = con9.CreateCommand();
                        insertingEmp.CommandText = "INSERT INTO RECEPTIONIST VALUES (RECEPTIONIST_ID.NEXTVAL, :name, :password, :email, :Qualification, :gender, :Salary)";

                        // Add parameters
                        insertingEmp.Parameters.Add(":name", OracleDbType.Varchar2).Value = textBox1.Text;
                        insertingEmp.Parameters.Add(":password", OracleDbType.Varchar2).Value = textBox2.Text;
                        insertingEmp.Parameters.Add(":email", OracleDbType.Varchar2).Value = textBox3.Text;
                        insertingEmp.Parameters.Add(":Qualification", OracleDbType.Varchar2).Value = comboBox2.Text;
                        insertingEmp.Parameters.Add(":gender", OracleDbType.Varchar2).Value = Gender;
                        insertingEmp.Parameters.Add(":Salary", OracleDbType.Varchar2).Value = textBox4.Text;

                        int rows = insertingEmp.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            con9.Close();
                            MessageBox.Show("RECEPTIONIST Account has been Successfully Registered");
                            // Hide current form and show Receptionist form
                            this.Hide();
                            Receptionist form = new Receptionist();
                            form.FormClosed += (s, args) => this.Close();
                            form.Show();
                        }
                    }
                    else
                    {
                        // Receptionist with the same name already exists
                        MessageBox.Show("A receptionist with the same name already exists. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error registering receptionist: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con9.Close();
                }



            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Logout Button
            this.Hide();
            Form1 form = new Form1();
            form.Closed += (s, args) => form.Close();
            form.Show();

        }
    }
}
