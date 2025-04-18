using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace WinFormsApp5
{
    public partial class Doctor_view : Form
    {
        OracleConnection con11;
        private string Doctor_Name;
        private string Doctor_Password;
        public Doctor_view(string Name, string Password)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Doctor_Name = Name;
            Doctor_Password = Password;
        }

        private void Tappbtn_Click(object sender, EventArgs e)
        {
            // Total appointment button
            // go to the appointment Page in Doctor view
            this.Hide();
            Total_App_IN_DOCTORS form1=new Total_App_IN_DOCTORS(Doctor_Name, Doctor_Password);
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }

        private void medicalhisBtn_Click(object sender, EventArgs e)
        {
            // Medical History button
        }

        private void Doc_Sal_Click(object sender, EventArgs e)
        {

        }

        private void Doc_Name_Click(object sender, EventArgs e)
        {

        }

        private void Doc_Password_Click(object sender, EventArgs e)
        {

        }

        private void Doc_Email_Click(object sender, EventArgs e)
        {

        }

        private void Doc_Gender_Click(object sender, EventArgs e)
        {

        }

        private void Doc_Qual_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_view_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE; USER ID=INSHALLL;PASSWORD=progr@mmer";
            con11 = new OracleConnection(conStr);


            con11.Open();
            OracleCommand command2 = con11.CreateCommand();
            command2.CommandText = "SELECT Name FROM DOCTORS WHERE Name = :name AND Password = :password";
            command2.CommandType = CommandType.Text;

            // Add parameters
            command2.Parameters.Add(new OracleParameter("name", Doctor_Name));
            command2.Parameters.Add(new OracleParameter("password", Doctor_Password));

            // Execute the command and get the result
            OracleDataReader reader = command2.ExecuteReader();

            if (reader.Read())
            {
                // If a row is returned, the username and password are correct
                Doctor.Text = reader["Name"].ToString();

                // Update label5 with the patient's name

                Doctor.Refresh();
            }
            // Close the reader and connection
            reader.Close();
            con11.Close();



            con11.Open();
            OracleCommand command = con11.CreateCommand();
            command.CommandText = "SELECT * FROM DOCTORS WHERE Name = :name AND Password = :password";
            command.CommandType = CommandType.Text;

            // Add parameters
            command.Parameters.Add(new OracleParameter("name", Doctor_Name));
            command.Parameters.Add(new OracleParameter("password", Doctor_Password));

            // Execute the command and get the result
            OracleDataReader reader1 = command.ExecuteReader();

            if (reader1.Read())
            {
                // If a row is returned, the username and password are correct
                Doc_Name.Text = reader1["Name"].ToString();

                // Update label5 with the patient's name

                Doc_Name.Refresh();

                Doc_Password.Text = reader1["Password"].ToString();
                Doc_Password.Refresh();


                Doc_Sal.Text = reader1["SALARY"].ToString();
                Doc_Sal.Refresh();

                Doc_Qual.Text = reader1["QUALIFICATION"].ToString();
                Doc_Qual.Refresh();


                Doc_Email.Text = reader1["Email"].ToString();
                Doc_Email.Refresh();

                Doc_Gender.Text = reader1["GENDER"].ToString();
                Doc_Gender.Refresh();





                //   Patient_CNIC.Text = reader1[]

            }
            // Close the reader and connection
            reader1.Close();
            con11.Close();









        }

        private void Doctor_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Closed += (s, args) => form.Close();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
