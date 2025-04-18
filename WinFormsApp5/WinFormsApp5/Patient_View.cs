using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.ManagedDataAccess.Client;

namespace WinFormsApp5
{
    public partial class Patient_View : Form
    {
        OracleConnection con11;
        private string patientName;
        private string patientPassword;
        public Patient_View()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;// Maximize The page
        }
        public Patient_View(string name, string password)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;// Maximize The page
            patientName = name;
            patientPassword = password;
        }

        private void Patient_View_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE; USER ID=INSHALLL;PASSWORD=progr@mmer";
            con11 = new OracleConnection(conStr);


            con11.Open();
            OracleCommand command2 = con11.CreateCommand();
            command2.CommandText = "SELECT Name FROM PATIENT WHERE Name = :name AND Password = :password";
            command2.CommandType = CommandType.Text;

            // Add parameters
            command2.Parameters.Add(new OracleParameter("name", patientName));
            command2.Parameters.Add(new OracleParameter("password", patientPassword));

            // Execute the command and get the result
            OracleDataReader reader = command2.ExecuteReader();

            if (reader.Read())
            {
                // If a row is returned, the username and password are correct
                label5.Text = reader["Name"].ToString();

                // Update label5 with the patient's name

                label5.Refresh();
            }
            // Close the reader and connection
            reader.Close();
            con11.Close();



            con11.Open();
            OracleCommand command = con11.CreateCommand();
            command.CommandText = "SELECT * FROM PATIENT WHERE Name = :name AND Password = :password";
            command.CommandType = CommandType.Text;

            // Add parameters
            command.Parameters.Add(new OracleParameter("name", patientName));
            command.Parameters.Add(new OracleParameter("password", patientPassword));

            // Execute the command and get the result
            OracleDataReader reader1 = command.ExecuteReader();

            if (reader1.Read())
            {
                // If a row is returned, the username and password are correct
                Patient_Name.Text = reader1["Name"].ToString();

                // Update label5 with the patient's name

                Patient_Name.Refresh();

                Patient_Password.Text = reader1["Password"].ToString();
                Patient_Password.Refresh();


                Patient_BG.Text = reader1["BLOODGROUP"].ToString();
                Patient_BG.Refresh();

                Patient_CNIC.Text = reader1["CNIC"].ToString();
                Patient_CNIC.Refresh();


                P_Email.Text = reader1["Email"].ToString();
                P_Email.Refresh();

                P_Gender.Text = reader1["GENDER"].ToString();
                P_Gender.Refresh();

                P_Address.Text = reader1["ADDRESS"].ToString();
                P_Address.Refresh();




                //   Patient_CNIC.Text = reader1[]

            }
            // Close the reader and connection
            reader1.Close();
            con11.Close();











        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Patient Name with the icon



        }

        private void Tappbtn_Click(object sender, EventArgs e)
        {
            // total appointment button
            this.Hide();
            Total_Appointments_in_PatientView form = new Total_Appointments_in_PatientView(Patient_Name.Text, Patient_Password.Text);
            form.Closed += (s, args) => form.Close();
            form.Show();
        }

        private void medicalhisBtn_Click(object sender, EventArgs e)
        {
            // medicalhistroy button
        }

        private void Patient_Name_Click(object sender, EventArgs e)
        {
            // Patient name
        }

        private void Patient_Password_Click(object sender, EventArgs e)
        {
            // Patient password
        }

        private void Patient_CNIC_Click(object sender, EventArgs e)
        {
            // Patient CNIC
        }

        private void Patient_BG_Click(object sender, EventArgs e)
        {
            // patient blood Group
        }

        private void P_Email_Click(object sender, EventArgs e)
        {
            // Patient Email
        }

        private void P_Gender_Click(object sender, EventArgs e)
        {
            // patient Gender
        }

        private void P_Address_Click(object sender, EventArgs e)
        {
            // Patient address
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            // Logout button
            this.Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Patient  Open Receptionist page to get appointments
            this.Hide();
            Receptionist_In_Patient form = new Receptionist_In_Patient(Patient_Name.Text, Patient_Password.Text);
            form.Closed += (s, args) => form.Close();
            form.Show();
        }
    }
}
