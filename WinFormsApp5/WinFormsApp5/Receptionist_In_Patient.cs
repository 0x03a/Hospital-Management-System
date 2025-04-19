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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp5
{
    public partial class Receptionist_In_Patient : Form
    {
        private string Patient_Name = "";
        private string Patient_Password = "";

        private const int FEE = 500;// Every Patient Fee


        OracleConnection con11;
        public Receptionist_In_Patient()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public Receptionist_In_Patient(string patient_name, string p_Password)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Patient_Name = patient_name;
            Patient_Password = p_Password;
        }

        private void Tappbtn_Click(object sender, EventArgs e)
        {
            // Total appointment button
        }

        private void medicalhisBtn_Click(object sender, EventArgs e)
        {
            // Medical history button
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Receptionist button
            this.Hide();
            Patient_View form = new Patient_View(Patient_Name, Patient_Password);
            form.Closed += (s, args) => form.Close();
            form.Show();
        }

        private void Receptionist_In_Patient_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE; USER ID=INSHALLL;PASSWORD=progr@mmer";
            con11 = new OracleConnection(conStr);


            // Open the connection
            con11.Open();

            // Create a command to retrieve doctor names
            OracleCommand command3 = con11.CreateCommand();
            command3.CommandText = "SELECT Name FROM DOCTORS";
            command3.CommandType = CommandType.Text;

            // Execute the command and get the result
            OracleDataReader reader3 = command3.ExecuteReader();

            // Loop through the result and add each doctor name to the ComboBox
            while (reader3.Read())
            {
                string doctorName = reader3["Name"].ToString();
                comboBox1.Items.Add(doctorName);
            }

            // Close the reader and connection
            reader3.Close();
            con11.Close();
            label8.Text = Patient_Name;
            // Set the DropDownStyle to DropDownList to prevent typing in the ComboBox
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;



            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            // Set the font style of column headers to bold
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Patient_name_label_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {


            label6.Text = comboBox1.GetItemText(comboBox1.SelectedItem);
            updateGrid(label6.Text.ToString());


        }

        private void updateGrid(string name)
        {


            int doctorIdD = -1;
            // Retrieve the doctor's ID from the database using the selected name

            doctorIdD = GetDoctorIdFromName(name);

            // Open the connection
            con11.Open();

            // Create a command
            OracleCommand getEmps = con11.CreateCommand();

            // Set the command text with a parameter for Doctor ID
            getEmps.CommandText = "SELECT S_Time, E_Time, DAY FROM SCHEDULE WHERE DOCTOR_ID = :doctorIdd";

            // Add the parameter
            getEmps.Parameters.Add(":doctorIdd", OracleDbType.Int32).Value = doctorIdD;

            // Execute the command
            OracleDataReader empDR = getEmps.ExecuteReader();

            // Load data into a DataTable
            DataTable empDT = new DataTable();
            empDT.Load(empDR);

            // Set DataGridView's data source to the DataTable
            dataGridView1.DataSource = empDT;

            con11.Close();

        }



        private int GetDoctorIdFromName(string doctorName)
        {
            int doctorId = -1; // Default value if doctor ID is not found


            try
            {
                con11.Open();
                OracleCommand getDoctorIdCmd = con11.CreateCommand();
                getDoctorIdCmd.CommandText = "SELECT ID FROM DOCTORS WHERE Name = :doctorName";

                // Add parameter without ":" in the parameter name
                getDoctorIdCmd.Parameters.Add("doctorName", OracleDbType.Varchar2).Value = doctorName;

                // Execute the command and get the doctor ID
                object result = getDoctorIdCmd.ExecuteScalar();

                // Ensure result is not null before conversion
                if (result != null && result != DBNull.Value)
                {

                    doctorId = Convert.ToInt32(result);

                    con11.Close();
                    return doctorId;
                }
                else
                {
                    MessageBox.Show("Doctor ID not found for name: " + doctorName, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                MessageBox.Show("Error getting Doctor ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con11.Close();
            }

            return doctorId;
        }


        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // diease text_box
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void appoint_bnt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show(" Select the Doctor first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show(" Write Your disease first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Assuming dataGridView1 is your DataGridView instance

            // Check if there are any rows
            if (dataGridView1.Rows.Count > 0)
            {
                // Assuming you want to retrieve data from the first row
                DataGridViewRow firstRow = dataGridView1.Rows[0];
                bool hasNullValue = false;

                // Get the indices of the columns
                int sTimeColumnIndex = dataGridView1.Columns["S_Time"].Index;
                int eTimeColumnIndex = dataGridView1.Columns["E_Time"].Index;
                int dayColumnIndex = dataGridView1.Columns["DAY"].Index;

                // Check each column for null or empty values
                if (firstRow.Cells[sTimeColumnIndex].Value == null || string.IsNullOrWhiteSpace(firstRow.Cells[sTimeColumnIndex].Value.ToString()))
                {
                    hasNullValue = true;
                }
                else if (firstRow.Cells[eTimeColumnIndex].Value == null || string.IsNullOrWhiteSpace(firstRow.Cells[eTimeColumnIndex].Value.ToString()))
                {
                    hasNullValue = true;
                }
                else if (firstRow.Cells[dayColumnIndex].Value == null || string.IsNullOrWhiteSpace(firstRow.Cells[dayColumnIndex].Value.ToString()))
                {
                    hasNullValue = true;
                }

                if (hasNullValue)
                {
                    // Show error message box
                    MessageBox.Show("Doctor has no following schedule!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                // No rows are available
                MessageBox.Show("No rows available in the DataGridView.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }





            // getting the Patient id to insert data in the appointment Table
            if (!string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show(" Appointed Sccuessfully!", "Information", MessageBoxButtons.OK);
                con11.Open();
                OracleCommand getPatient_id = con11.CreateCommand();
                getPatient_id.CommandText = "SELECT ID FROM PATIENT WHERE NAME= :p_name ";
                // Add parameter without ":" in the parameter name
                getPatient_id.Parameters.Add("p_name", OracleDbType.Varchar2).Value = Patient_Name;
                // Execute the command and get the Patient_ID
                object result = getPatient_id.ExecuteScalar();
                int patient_Id = Convert.ToInt32(result);

                con11.Close();
                string sTime = "";
                string eTime = "";
                string day = "";
                // Reteriving the Shecdule data
                if (dataGridView1.Rows.Count > 0)
                {
                    // Assuming you want to retrieve data from the first row
                    DataGridViewRow firstRow = dataGridView1.Rows[0];

                    // Get the indices of the columns
                    int sTimeColumnIndex = dataGridView1.Columns["S_Time"].Index;
                    int eTimeColumnIndex = dataGridView1.Columns["E_Time"].Index;
                    int dayColumnIndex = dataGridView1.Columns["DAY"].Index;

                    // Retrieve data from the first row
                    sTime = firstRow.Cells[sTimeColumnIndex].Value?.ToString();
                    eTime = firstRow.Cells[eTimeColumnIndex].Value?.ToString();
                    day = firstRow.Cells[dayColumnIndex].Value?.ToString();

                    // Use the retrieved data as needed
                    // For example, you can display it in message boxes
                    MessageBox.Show($"S_Time: {sTime}, E_Time: {eTime}, DAY: {day}", "Data from First Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // No rows are available
                    MessageBox.Show("No rows available in the DataGridView.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }




                string doctor_name = comboBox1.Text.ToString();
                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                con11.Open();
                OracleCommand insert_Into_Appointment_Table = con11.CreateCommand();
                insert_Into_Appointment_Table.CommandText = @"
    INSERT INTO APPOINTMENT (PATIENT_ID, S_TIME, E_TIME, STATUS, A_DATE, FEE, DISEASE, DOCTOR_NAME, A_ID)
    VALUES (:p_id, :starting_time, :ending_time, :status, TO_DATE(:date_value, 'YYYY-MM-DD'), :fee, :disease, :doctor_name, A_ID.NEXTVAL)";

                insert_Into_Appointment_Table.Parameters.Add(":p_id", OracleDbType.Int32).Value = patient_Id;
                insert_Into_Appointment_Table.Parameters.Add(":starting_time", OracleDbType.Varchar2).Value = sTime;
                insert_Into_Appointment_Table.Parameters.Add(":ending_time", OracleDbType.Varchar2).Value = eTime;
                insert_Into_Appointment_Table.Parameters.Add(":status", OracleDbType.Varchar2).Value = "PENDING";
                insert_Into_Appointment_Table.Parameters.Add(":date_value", OracleDbType.Varchar2).Value = date;
                insert_Into_Appointment_Table.Parameters.Add(":fee", OracleDbType.Decimal).Value = FEE;
                insert_Into_Appointment_Table.Parameters.Add(":disease", OracleDbType.Varchar2).Value = textBox1.Text.ToString();
                insert_Into_Appointment_Table.Parameters.Add(":doctor_name", OracleDbType.Varchar2).Value = doctor_name;

                insert_Into_Appointment_Table.CommandType = CommandType.Text;
                int rows = insert_Into_Appointment_Table.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("APPOINTMENT Account has been Successfully Registered", "INFORMATION", MessageBoxButtons.OK);
                }






                con11.Close();

                this.Hide();
                Patient_View form = new Patient_View(Patient_Name, Patient_Password);
                form.Closed += (s, args) => form.Close();
                form.Show();




                return;
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

        private void label8_Click(object sender, EventArgs e)
        {
            // patient_name label
        }

        private void Tappbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Total_Appointments_in_PatientView form1 = new Total_Appointments_in_PatientView(Patient_Name, Patient_Password);
            form1.Closed += (s, args) => form1.Close();
            form1.Show();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // Receptionist button , by pressing it you will go to home page
            this.Hide();
            Patient_View form1 = new Patient_View(Patient_Name, Patient_Password);
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }
    }
}
