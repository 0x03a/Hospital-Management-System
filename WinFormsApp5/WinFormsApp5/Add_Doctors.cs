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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace WinFormsApp5
{
    public partial class Add_Doctors : Form
    {
        OracleConnection con2;

        public Add_Doctors()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Doctor Button
            this.Hide();
            Doctor form = new Doctor();
            form.Closed += (s, args) => form.Close();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Go to the Patient page, viwed by Admin
            this.Hide();
            PatientinAdmin form = new PatientinAdmin();
            form.Closed += (s, args) => form.Close();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Return to admin page
            Form1 form = new Form1();
            this.Hide();
            form.Closed += (s, args) => form.Close();
            form.Show();
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

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            // if empty show error
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {

                errorProvider1.SetError(textBox1, "Please Enter the Doctor Name");

            }
            else
            {

                errorProvider1.SetError(textBox3, string.Empty); // else clear the error 

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            // if empty show error
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {

                errorProvider1.SetError(textBox2, "Please Enter the Doctor Password");

            }
            else
            {

                errorProvider1.SetError(textBox2, string.Empty); // else clear the error 

            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            // if empty show error
            if (string.IsNullOrEmpty(textBox3.Text) == true)
            {

                errorProvider1.SetError(textBox3, "Please Enter the Doctor Email");

            }
            else
            {

                errorProvider1.SetError(textBox3, string.Empty); // else clear the error 

            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            // if empty show error
            if (string.IsNullOrEmpty(textBox4.Text) == true)
            {

                errorProvider1.SetError(textBox4, "Please Enter the Doctor Salary");

            }
            else
            {

                errorProvider1.SetError(textBox4, string.Empty); // else clear the error 

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

               
               


                con2.Open();

                string doctorPassword = textBox2.Text.Trim();

                // Check if the password is already used by any patient
                OracleCommand checkPatientPasswordCmd = con2.CreateCommand();
                checkPatientPasswordCmd.CommandText = "SELECT COUNT(*) FROM PATIENT WHERE password = :password";
                checkPatientPasswordCmd.Parameters.Add(":password", OracleDbType.Varchar2).Value = doctorPassword;
                int patientPasswordCount = Convert.ToInt32(checkPatientPasswordCmd.ExecuteScalar());





                // Check if the password is already used by any doctor
                OracleCommand checkDoctorPasswordCmd = con2.CreateCommand();
                checkDoctorPasswordCmd.CommandText = "SELECT COUNT(*) FROM DOCTORS WHERE password = :password";
                checkDoctorPasswordCmd.Parameters.Add(":password", OracleDbType.Varchar2).Value = doctorPassword;
                int doctorPasswordCount = Convert.ToInt32(checkDoctorPasswordCmd.ExecuteScalar());


               



                if (doctorPasswordCount > 0)
                {
                    MessageBox.Show("Error: Please choose a different password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con2.Close();
                    return;
                }

                if (patientPasswordCount > 0)
                {
                    MessageBox.Show("Error: Please choose a different password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con2.Close();
                    return;
                }

                con2.Close();



                con2.Open();

                // Check if the name already exists
                OracleCommand checkNameCmd = con2.CreateCommand();
                checkNameCmd.CommandText = "SELECT COUNT(*) FROM DOCTORS WHERE name = :name";
                checkNameCmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = textBox1.Text;
                int nameCount = Convert.ToInt32(checkNameCmd.ExecuteScalar());

                // Check if the password is valid
                OracleCommand checkPasswordCmd = con2.CreateCommand();
                checkPasswordCmd.CommandText = "SELECT COUNT(*) FROM DOCTORS WHERE password = :password";
                checkPasswordCmd.Parameters.Add(":password", OracleDbType.Varchar2).Value = textBox2.Text;
                int passwordCount = Convert.ToInt32(checkPasswordCmd.ExecuteScalar());




                // check email if they exist doctor and in another table 
                string email1 = textBox3.Text.Trim();
                OracleCommand cmdGetOriginalEmail = con2.CreateCommand();
                cmdGetOriginalEmail.CommandText = "SELECT  COUNT(*) FROM DOCTORS WHERE  email = :demail";
                cmdGetOriginalEmail.Parameters.Clear();
                cmdGetOriginalEmail.Parameters.Add("demail", OracleDbType.Varchar2).Value = email1;


                int Dmail = Convert.ToInt32(cmdGetOriginalEmail.ExecuteScalar());

                



                cmdGetOriginalEmail.CommandText = "SELECT COUNT(*) FROM PATIENT WHERE  email = :demail";
                cmdGetOriginalEmail.Parameters.Clear();

                cmdGetOriginalEmail.Parameters.Add("demail", OracleDbType.Varchar2).Value = email1;
                int Pmail = Convert.ToInt32(cmdGetOriginalEmail.ExecuteScalar());


                cmdGetOriginalEmail.CommandText = "SELECT  COUNT(*) FROM NURSE WHERE  email = :demail";
                cmdGetOriginalEmail.Parameters.Clear();

                cmdGetOriginalEmail.Parameters.Add("demail", OracleDbType.Varchar2).Value = email1;
                int Nmail = Convert.ToInt32(cmdGetOriginalEmail.ExecuteScalar());



                cmdGetOriginalEmail.CommandText = "SELECT  COUNT(*) FROM RECEPTIONIST WHERE  email = :demail";
                cmdGetOriginalEmail.Parameters.Clear();

                cmdGetOriginalEmail.Parameters.Add("demail", OracleDbType.Varchar2).Value = email1;
                int Rmail = Convert.ToInt32(cmdGetOriginalEmail.ExecuteScalar());








                if (nameCount > 0)
                {

                    MessageBox.Show("Error: A doctor with the same name already exists. Please enter a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con2.Close();
                    return;
                }
                else if (passwordCount > 0)
                {
                    MessageBox.Show("Error: The password is already in use. Please choose a different password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con2.Close();
                    return;
                }
                else if (textBox1.Text == "Inshal")
                {
                    MessageBox.Show("Error:  Please choose a different Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con2.Close();
                    return;
                }
               else if (Dmail > 0 || Pmail > 0 || Rmail > 0 || Nmail > 0)
                {
                    // Password match found in the patient table
                    MessageBox.Show(" Please choose a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con2.Close();
                    return;
                }
                else
                {
                    // If all checks pass, proceed with insertion
                    OracleCommand insertingEmp = con2.CreateCommand();
                    insertingEmp.CommandText = "INSERT INTO DOCTORS VALUES (DOC_ID.NEXTVAL, :name, :password, :email, :Qualification, :gender, :Salary)";

                    // Add parameters
                    insertingEmp.Parameters.Add(":name", OracleDbType.Varchar2).Value = textBox1.Text;
                    insertingEmp.Parameters.Add(":password", OracleDbType.Varchar2).Value = textBox2.Text;
                    insertingEmp.Parameters.Add(":email", OracleDbType.Varchar2).Value = textBox3.Text;
                    insertingEmp.Parameters.Add(":Qualification", OracleDbType.Varchar2).Value = comboBox2.Text;
                    insertingEmp.Parameters.Add(":gender", OracleDbType.Varchar2).Value = Gender;
                    insertingEmp.Parameters.Add(":Salary", OracleDbType.Varchar2).Value = textBox4.Text;

                    insertingEmp.CommandType = CommandType.Text;

                    try
                    {
                        int rows = insertingEmp.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Doctor Account has been Successfully Registered");
                            // after inserting hide patient form Return to 1st Form
                            this.Hide();
                            Doctor form = new Doctor();
                            form.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occurred while inserting doctor account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                con2.Close();


            }










        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Doctors_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=INSHALLL;PASSWORD=progr@mmer";
            con2 = new OracleConnection(conStr);

            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Receptionist button
            this.Hide();
            Receptionist form = new Receptionist();
            form.Closed += (s, args) => form.Close();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Go to the  Nurse page
            this.Hide();
            Nurse form = new Nurse();
            form.Closed += (s, args) => form.Close();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Appointment Button
            // Go to the Appointpage page
            this.Hide();
            Total_Appointments_IN_Admin form1 = new Total_Appointments_IN_Admin();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }
    }
}
