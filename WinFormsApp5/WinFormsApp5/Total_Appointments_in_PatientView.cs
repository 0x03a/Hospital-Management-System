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
    public partial class Total_Appointments_in_PatientView : Form
    {
        OracleConnection con12;
        public Total_Appointments_in_PatientView()
        {
            InitializeComponent();
        }

        private string Patient_Name = "";
        private string Patient_Password = "";
        public Total_Appointments_in_PatientView(string patient_name, string p_Password)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Patient_Name = patient_name;
            Patient_Password = p_Password;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Total_Appointments_in_PatientView_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE; USER ID=INSHALLL;PASSWORD=progr@mmer";
            con12 = new OracleConnection(conStr);
            updateGrid();
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            // Set the font style of column headers to bold
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            // Define custom colors
            Color lightRed = Color.FromArgb(220, 120, 120); // Light Red
            Color lightGreen = Color.FromArgb(144, 238, 144); // Light Green


        }

        private void updateGrid()// for viewing the records
        {
            con12.Open();
            OracleCommand getPatient_id = con12.CreateCommand();
            getPatient_id.CommandText = "SELECT ID FROM PATIENT WHERE NAME= :p_name ";
            // Add parameter without ":" in the parameter name
            getPatient_id.Parameters.Add("p_name", OracleDbType.Varchar2).Value = Patient_Name;
            // Execute the command and get the Patient_ID
            object result = getPatient_id.ExecuteScalar();
            int patient_Id = Convert.ToInt32(result);

            con12.Close();




            con12.Open();
            OracleCommand getEmps = con12.CreateCommand();
            getEmps.CommandText = "SELECT PATIENT_ID, DOCTOR_NAME, S_TIME, E_TIME, STATUS, A_DATE, FEE, DISEASE FROM APPOINTMENT WHERE PATIENT_ID = :P_id ORDER BY A_DATE";
            // Add parameter for Patient_Name
            getEmps.Parameters.Add(":P_id", OracleDbType.Varchar2).Value = patient_Id;
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);

            dataGridView1.DataSource = empDT;
            label5.Text = Patient_Name;
            con12.Close();
            Color lightRed = Color.FromArgb(220, 120, 120); // Light Red
            Color lightGreen = Color.FromArgb(144, 238, 144); // Light Green
            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Get the cell in the 6th column
                DataGridViewCell cell = row.Cells[4]; // 6th column (index 5)

                // Check if the cell value equals "PENDING"
                if (cell.Value != null && cell.Value.ToString() == "PENDING")
                {
                    // Change the background color to Light Red
                    cell.Style.BackColor = lightRed;
                    // Change the foreground color to White
                    cell.Style.ForeColor = Color.Black;
                    // Make the text bold
                    cell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                }
                // Check if the cell value equals "APPROVED"
                else if (cell.Value != null && cell.Value.ToString() == "APPROVED")
                {
                    // Change the background color to Light Green
                    cell.Style.BackColor = lightGreen;
                    // Reset the foreground color to Black (default)
                    cell.Style.ForeColor = Color.Black;
                    // Make the text bold
                    cell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                }
                else
                {
                    // Reset the background and foreground colors, and the font style
                    cell.Style.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                    cell.Style.ForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                    cell.Style.Font = new Font(dataGridView1.Font, FontStyle.Regular);
                }
            }
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
            // Receptionist Button
            this.Hide();
            Receptionist_In_Patient form1 = new Receptionist_In_Patient(Patient_Name, Patient_Password);
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }

        private void Patient_name_label_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Tappbtn_Click(object sender, EventArgs e)
        {
            // by pressing it go back to home page(patient_View)
            this.Hide();
            Patient_View form1 = new Patient_View(Patient_Name, Patient_Password);
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }
    }
}
