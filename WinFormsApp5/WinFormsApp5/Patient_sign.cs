using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Oracle.ManagedDataAccess.Client;
using System.Net.Mail;
using System.Net;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using Ax.IO;

namespace WinFormsApp5
{
    public partial class Patient_sign : Form
    {
        OracleConnection con;
        String randomCode;
        public static String to;
        public Patient_sign()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            INSERTbutton.Visible = false;
        
        }


        private void updateGird()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT * FROM PATIENT; ";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
           
            con.Close();
          

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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            // if empty show error
            if (string.IsNullOrEmpty(textBox7.Text) == true)
            {

                errorProvider5.SetError(textBox7, "Please Enter the Address");
                return;
            }
            else
            {
                errorProvider5.SetError(textBox7, string.Empty); // else clear the error 
                btnsend.Visible= true;

            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            // if empty show error
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {

                errorProvider1.SetError(textBox1, "Please Enter the Name");
                return;
            }
            else
                errorProvider1.SetError(textBox1, string.Empty); // else clear the error 
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            // if empty show error
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {

                errorProvider2.SetError(textBox2, "Please Enter the Password");
                return;
            }
            else
                errorProvider2.SetError(textBox2, string.Empty); // else clear the error 
        }



        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            // if empty show error
            if (string.IsNullOrEmpty(txtEmail.Text) == true)
            {

                errorProvider4.SetError(txtEmail, "Please Enter the email");
                return;
            }
            else
                errorProvider4.SetError(txtEmail, string.Empty); // else clear the error 
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_Validating(object sender, CancelEventArgs e)
        {
            // if empty show error
            if (string.IsNullOrEmpty(maskedTextBox2.Text) == true)
            {

                errorProvider3.SetError(maskedTextBox2, "Please Enter the CNIC");
                return;
            }
            else
                errorProvider3.SetError(maskedTextBox2, string.Empty); // else clear the error 
        }

        private void Patient_sign_Load(object sender, EventArgs e)
        {

            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=INSHALLL;PASSWORD=progr@mmer";
            con = new OracleConnection(conStr);

        }

        private void INSERTbutton_Click(object sender, EventArgs e)
        {
            // Validate the CNIC format using regular expression
            string cnicPattern = @"\d{5}-\d{8}-\d{1}";
            bool flag1 = false;
            bool flag2 = false;
            bool flag3 = false;
            // flag2 and flag3 for checkbox and flag1 for radio button

            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                MessageBox.Show("Enter your name please");
            }
            else if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                MessageBox.Show("Enter your Password please");
            }
            else if (string.IsNullOrEmpty(txtEmail.Text) == true)
            {
                MessageBox.Show("Enter your Email Please");
            }
            else if (maskedTextBox2.Text == "     -        -")
            {
                MessageBox.Show("Enter your CNIC in the correct format (e.g., XXXXX-XXXXXXXX-X).");
            }
            else if (!Regex.IsMatch(maskedTextBox2.Text.ToString(), cnicPattern))
            {
                MessageBox.Show("Enter your CNIC in the correct format (e.g., XXXXX-XXXXXXXX-X).");
            }
            else if (string.IsNullOrEmpty(textBox7.Text) == true)
            {
                MessageBox.Show("Enter your Address please");
            }

            string radiobutton = "";
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked || radioButton5.Checked || radioButton6.Checked || radioButton7.Checked || radioButton8.Checked)
            {
                if (radioButton1.Checked)
                {
                    radiobutton = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    radiobutton = radioButton2.Text;
                }
                else if (radioButton3.Checked)
                {
                    radiobutton = radioButton3.Text;
                }
                else if (radioButton4.Checked)
                {
                    radiobutton = radioButton4.Text;
                }
                else if (radioButton5.Checked)
                {
                    radiobutton = radioButton5.Text;
                }
                else if (radioButton6.Checked)
                {
                    radiobutton = radioButton6.Text;
                }
                else if (radioButton7.Checked)
                {
                    radiobutton = radioButton7.Text;
                }
                else
                {
                    radiobutton = radioButton8.Text;
                }

                flag1 = true;
            }
            else
            {
                MessageBox.Show(" Blood Group is Not Selected");
                flag1 = false;
            }

            if (checkBox1.Checked || checkBox2.Checked)
            {
                if (checkBox1.Checked)
                {
                    flag2 = true;
                }
                else
                { flag3 = true; }
            }
            else
            {
                MessageBox.Show(" Gender is Not Selected");
                flag2 = false;
            }



            if (string.IsNullOrEmpty(textBox1.Text) != true && string.IsNullOrEmpty(textBox2.Text) != true && string.IsNullOrEmpty(txtEmail.Text) != true && Regex.IsMatch(maskedTextBox2.Text.ToString(), cnicPattern) && flag1)
            {
                if (flag2 && string.IsNullOrEmpty(textBox7.Text) != true)
                { // for checkbo
                    con.Open();

                    string patientName = textBox1.Text.Trim();
                    string patientAddress = textBox7.Text.Trim();
                    string patientPassword = textBox2.Text.Trim();

                    // Check if the name already exists
                    OracleCommand checkNameCmd = con.CreateCommand();
                    checkNameCmd.CommandText = "SELECT COUNT(*) FROM PATIENT WHERE name = :name";
                    checkNameCmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = patientName;
                    int nameCount = Convert.ToInt32(checkNameCmd.ExecuteScalar());

                    // Check if the password is valid
                    OracleCommand checkPasswordCmd = con.CreateCommand();
                    checkPasswordCmd.CommandText = "SELECT COUNT(*) FROM PATIENT WHERE password = :password";
                    checkPasswordCmd.Parameters.Add(":password", OracleDbType.Varchar2).Value = patientPassword;
                    int passwordCount = Convert.ToInt32(checkPasswordCmd.ExecuteScalar());

                    // Check if the password matches any doctor's password
                    OracleCommand checkDoctorPasswordCmd = con.CreateCommand();
                    checkDoctorPasswordCmd.CommandText = "SELECT COUNT(*) FROM DOCTORS WHERE password = :password";
                    checkDoctorPasswordCmd.Parameters.Add(":password", OracleDbType.Varchar2).Value = patientPassword;
                    int doctorPasswordCount = Convert.ToInt32(checkDoctorPasswordCmd.ExecuteScalar());

                    if (nameCount > 0)
                    {
                        MessageBox.Show("Error: A patient with the same name already exists. Please enter a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (passwordCount > 0)
                    {
                        MessageBox.Show("Error: The password is already in use. Please choose a different password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (patientName.Equals("Inshal", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Error: The patient name cannot be 'Inshal'. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(patientAddress))
                    {
                        MessageBox.Show("Error: Please provide the patient address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (doctorPasswordCount > 0)
                    {
                        MessageBox.Show("Error: The password matches a doctor's password. Please choose a different password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // If all checks pass, proceed with insertion
                        OracleCommand insertingEmp = con.CreateCommand();
                        insertingEmp.CommandText = "INSERT INTO PATIENT VALUES (ID.NEXTVAL, :name, :password, :email, :bloodGroup, :gender, :address, :CNIC)";

                        // Add parameters
                        insertingEmp.Parameters.Add(":name", OracleDbType.Varchar2).Value = patientName;
                        insertingEmp.Parameters.Add(":password", OracleDbType.Varchar2).Value = patientPassword;
                        insertingEmp.Parameters.Add(":email", OracleDbType.Varchar2).Value = txtEmail.Text;
                        insertingEmp.Parameters.Add(":bloodGroup", OracleDbType.Varchar2).Value = radiobutton;
                        insertingEmp.Parameters.Add(":gender", OracleDbType.Varchar2).Value = checkBox1.Text;
                        insertingEmp.Parameters.Add(":address", OracleDbType.Varchar2).Value = patientAddress;
                        insertingEmp.Parameters.Add(":CNIC", OracleDbType.Varchar2).Value = maskedTextBox2.Text;

                        insertingEmp.CommandType = CommandType.Text;

                        try
                        {
                            int rows = insertingEmp.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                MessageBox.Show("Your Account has been Successfully Registered");
                                // after inserting hide patient form Return to 1st Form
                                this.Hide();
                                Form1 form1 = new Form1();
                                form1.Show();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error occurred while inserting patient account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    con.Close();


                }
                else if (flag3 && string.IsNullOrEmpty(textBox7.Text) != true)
                {

                    con.Open();

                    string patientName = textBox1.Text.Trim();
                    string patientAddress = textBox7.Text.Trim();
                    string patientPassword = textBox2.Text.Trim();

                    // Check if the name already exists
                    OracleCommand checkNameCmd = con.CreateCommand();
                    checkNameCmd.CommandText = "SELECT COUNT(*) FROM PATIENT WHERE name = :name";
                    checkNameCmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = patientName;
                    int nameCount = Convert.ToInt32(checkNameCmd.ExecuteScalar());

                    // Check if the password is valid
                    OracleCommand checkPasswordCmd = con.CreateCommand();
                    checkPasswordCmd.CommandText = "SELECT COUNT(*) FROM PATIENT WHERE password = :password";
                    checkPasswordCmd.Parameters.Add(":password", OracleDbType.Varchar2).Value = patientPassword;
                    int passwordCount = Convert.ToInt32(checkPasswordCmd.ExecuteScalar());

                    // Check if the address is provided
                    bool addressProvided = !string.IsNullOrEmpty(patientAddress);

                    // Check if the password matches any doctor's password
                    OracleCommand checkDoctorPasswordCmd = con.CreateCommand();
                    checkDoctorPasswordCmd.CommandText = "SELECT COUNT(*) FROM DOCTORS WHERE Password = :password";
                    checkDoctorPasswordCmd.Parameters.Add(":password", OracleDbType.Varchar2).Value = patientPassword;
                    int doctorPasswordCount = Convert.ToInt32(checkDoctorPasswordCmd.ExecuteScalar());

                    if (nameCount > 0)
                    {
                        MessageBox.Show("Error: A patient with the same name already exists. Please enter a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (passwordCount > 0)
                    {
                        MessageBox.Show("Error: The password is already in use. Please choose a different password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (doctorPasswordCount > 0)
                    {
                        MessageBox.Show("Error: The password matches a doctor's password. Please choose a different password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (patientName.Equals("Inshal", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Error: The patient name cannot be 'Inshal'. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!addressProvided)
                    {
                        MessageBox.Show("Error: Please provide the patient address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // If all checks pass, proceed with insertion
                        OracleCommand insertingEmp = con.CreateCommand();
                        insertingEmp.CommandText = "INSERT INTO PATIENT VALUES (ID.NEXTVAL, :name, :password, :email, :bloodGroup, :gender, :address, :CNIC)";

                        // Add parameters
                        insertingEmp.Parameters.Add(":name", OracleDbType.Varchar2).Value = patientName;
                        insertingEmp.Parameters.Add(":password", OracleDbType.Varchar2).Value = patientPassword;
                        insertingEmp.Parameters.Add(":email", OracleDbType.Varchar2).Value = txtEmail.Text;
                        insertingEmp.Parameters.Add(":bloodGroup", OracleDbType.Varchar2).Value = radiobutton;
                        insertingEmp.Parameters.Add(":gender", OracleDbType.Varchar2).Value = checkBox2.Text;
                        insertingEmp.Parameters.Add(":address", OracleDbType.Varchar2).Value = patientAddress;
                        insertingEmp.Parameters.Add(":CNIC", OracleDbType.Varchar2).Value = maskedTextBox2.Text;
                        insertingEmp.CommandType = CommandType.Text;

                        try
                        {
                            int rows = insertingEmp.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                MessageBox.Show("Your Account has been Successfully Registered");
                                // after inserting hide patient form Return to 1st Form
                                this.Hide();
                                Form1 form1 = new Form1();
                                form1.Show();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error occurred while inserting patient account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    con.Close();



                }
            }
        }
        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
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
        private void btnsend_Click(object sender, EventArgs e)
        {
          

            


            con.Open();

            string patientName = textBox1.Text.Trim();

            // Check if the name already exists
            OracleCommand checkNameCmd = con.CreateCommand();
            checkNameCmd.CommandText = "SELECT COUNT(*) FROM PATIENT WHERE name = :name";
            checkNameCmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = patientName;
            int nameCount = Convert.ToInt32(checkNameCmd.ExecuteScalar());

            // Check if the password is valid
            OracleCommand checkPasswordCmd = con.CreateCommand();
            checkPasswordCmd.CommandText = "SELECT COUNT(*) FROM PATIENT WHERE password = :password";
            checkPasswordCmd.Parameters.Add(":password", OracleDbType.Varchar2).Value = textBox2.Text;
            int passwordCount = Convert.ToInt32(checkPasswordCmd.ExecuteScalar());

            // Check if the password is already used by any doctor
            OracleCommand checkDoctorPasswordCmd = con.CreateCommand();
            checkDoctorPasswordCmd.CommandText = "SELECT COUNT(*) FROM DOCTORS WHERE password = :password";
            checkDoctorPasswordCmd.Parameters.Add(":password", OracleDbType.Varchar2).Value = textBox2.Text;
            int doctorPasswordCount = Convert.ToInt32(checkDoctorPasswordCmd.ExecuteScalar());

            if (nameCount > 0)
            {
                MessageBox.Show("Error: A patient with the same name already exists. Please enter a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            else if (passwordCount > 0)
            {
                MessageBox.Show("Error: The password is already in use. Please choose a different password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            else if (doctorPasswordCount > 0)
            {
                MessageBox.Show("Error: Please choose a different password for the patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            else if (patientName.Equals("Inshal", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Error: The patient name cannot be 'Inshal'. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }

            con.Close();


            if (!IsValid(txtEmail.Text))
            {
                MessageBox.Show("Email is Invalid");
                return;
            }

            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999).ToString());
            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "inshalbro@gmail.com";
            pass = "tinq spxo vgqk fsvp";
            messageBody = "Your reset code is: " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = " Password Reseting Code";
            SmtpClient smtpm = new SmtpClient("smtp.gmail.com");
            smtpm.EnableSsl = true;
            smtpm.Port = 587;
            smtpm.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpm.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtpm.Send(message);
                MessageBox.Show("Code Sent Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email. Error: " + ex.Message);
            }


        }

        private void Verifybtn_Click(object sender, EventArgs e)
        {
            if (randomCode == (textBox3.Text).ToString())
            {
                to = txtEmail.Text;
                MessageBox.Show(" Verified Successfully");
                btnsend.Visible = false;
                Verifybtn.Visible = false;
                INSERTbutton.Visible = true;
                textBox3.Visible = false;
                label11.Visible = false;
                label10.Visible = false;
                label9.Visible = false;
                txtEmail.Visible = false;
                label6.Visible = false;


            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Log out button
            this.Hide();
            Form1 form = new Form1();
            form.Closed += (s, args) => form.Close();
            form.Show();
        }
    }
}
