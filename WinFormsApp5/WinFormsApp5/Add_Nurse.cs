using Oracle.ManagedDataAccess.Client;
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
using Ax.Domain.Orcale;

namespace WinFormsApp5
{
    public partial class Add_Nurse : Form
    {
        OracleConnection con6;
        public Add_Nurse()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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
            string pass = Convert.ToString(textBox2.Text);
            if ((string.IsNullOrEmpty(textBox1.Text) != true) && (string.IsNullOrEmpty(textBox2.Text)) != true && string.IsNullOrEmpty(textBox3.Text) != true && IsValid(textBox3.Text) && string.IsNullOrEmpty(textBox4.Text) != true && (checkBox1.Checked == true || checkBox2.Checked == true) && string.IsNullOrEmpty(comboBox2.Text) != true)
            {



                try
                {
                    con6.Open();

                    // Check if nurse with the same name already exists
                    OracleCommand cmdCheckDuplicate = con6.CreateCommand();
                    cmdCheckDuplicate.CommandText = "SELECT COUNT(*) FROM NURSE WHERE UPPER(Name) = UPPER(:Name)";
                    cmdCheckDuplicate.Parameters.Add(":Name", OracleDbType.Varchar2).Value = textBox1.Text.Trim().ToUpper(); // Convert to uppercase for case-insensitive comparison

                    OracleCommand checkPassword = con6.CreateCommand();
                    checkPassword.CommandText = "SELECT COUNT(*) FROM PATIENT WHERE password =:pass1 ";
                    checkPassword.Parameters.Add(":pass1", OracleDbType.Varchar2).Value = pass;




                    int patientPasswordCount = Convert.ToInt32(checkPassword.ExecuteScalar());



                    checkPassword.CommandText = "SELECT COUNT(*) FROM NURSE WHERE Password = :pass1";

                    int NursePasswordCount = Convert.ToInt32(checkPassword.ExecuteScalar());


                    checkPassword.CommandText = "SELECT COUNT(*) FROM RECEPTIONIST WHERE Password = :pass1";

                    int ReceptionistPasswordCount = Convert.ToInt32(checkPassword.ExecuteScalar());


                    checkPassword.CommandText = "SELECT COUNT(*) FROM Doctors WHERE Password = :pass1";


                    int doctorPasswordCount = Convert.ToInt32(checkPassword.ExecuteScalar());





                    int existingCount = Convert.ToInt32(cmdCheckDuplicate.ExecuteScalar());

                    if (existingCount == 0 && patientPasswordCount == 0 && NursePasswordCount == 0 && ReceptionistPasswordCount == 0 && doctorPasswordCount == 0)
                    {
                        // No nurse with the same name exists, proceed with insertion
                        OracleCommand insertingEmp = con6.CreateCommand();
                        insertingEmp.CommandText = "INSERT INTO NURSE VALUES (NURSE_ID.NEXTVAL, :name, :password, :email, :Qualification, :gender, :Salary)";

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
                            con6.Close();
                            MessageBox.Show("Nurse Account has been Successfully Registered");
                            // Hide current form and show Nurse form
                            this.Hide();
                            Nurse form = new Nurse();
                            form.Closed += (s, args) => form.Close();
                            form.Show();
                        }
                    }
                    else
                    {
                        if (patientPasswordCount == 0 || NursePasswordCount == 0 || ReceptionistPasswordCount == 0 || doctorPasswordCount == 0)
                        {
                            // Nurse with the same name already exists
                            MessageBox.Show("Password Exists. Please choose different .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else  // Nurse with the same name already exists
                        MessageBox.Show("A nurse with the same name already exists. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error registering nurse: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con6.Close();
                }


            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            // log out button
            // go back to login/sign up page
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void Add_Nurse_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=INSHALLL;PASSWORD=progr@mmer";
            con6 = new OracleConnection(conStr);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Doctor button, go to the doctor page
            this.Hide();
            Doctor form = new Doctor();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Patient button
            this.Hide();
            PatientinAdmin form = new PatientinAdmin();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Appointment button, go the appointment Page
            this.Hide();
            Total_Appointments_IN_Admin form1 = new Total_Appointments_IN_Admin();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Nurse button to get back to admin page
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // update nurse
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Receptionist
            this.Hide();
            Receptionist form = new Receptionist();
            form.Closed += (s, args) => form.Close();
            form.Show();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            // checking that the name is empty or not

            // if empty show error
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {

                errorProvider1.SetError(textBox1, "Please Enter the Nurse Name");

            }
            else
            {

                errorProvider1.SetError(textBox3, string.Empty); // else clear the error 

            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            // checking that the Password is empty or not
            // if empty show error
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {

                errorProvider2.SetError(textBox2, "Please Enter the Nurse Name");

            }
            else
            {

                errorProvider2.SetError(textBox2, string.Empty); // else clear the error 

            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            // checking that the email is empty or not

            // if empty show error
            if (string.IsNullOrEmpty(textBox3.Text) == true)
            {

                errorProvider3.SetError(textBox3, "Please Enter the  Email");

            }
            else
            {

                errorProvider3.SetError(textBox3, string.Empty); // else clear the error 

            }
        }

        private void comboBox2_Validating(object sender, CancelEventArgs e)
        {


        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            // checking that the salary is empty or not

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
    }
}
