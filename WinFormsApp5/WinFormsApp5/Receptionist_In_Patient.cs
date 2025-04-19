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

        // Add this method to check if a time slot is available
        private bool IsTimeSlotAvailable(string doctorName, string date, string startTime)
        {
            bool isAvailable = true;

            try
            {
                con11.Open();
                OracleCommand checkSlotCmd = con11.CreateCommand();

                // Convert the selected date to Oracle format
                checkSlotCmd.CommandText = @"
            SELECT COUNT(*) 
            FROM APPOINTMENT 
            WHERE DOCTOR_NAME = :doctor_name 
            AND A_DATE = TO_DATE(:date_value, 'YYYY-MM-DD')
            AND S_TIME = :start_time";

                checkSlotCmd.Parameters.Add(":doctor_name", OracleDbType.Varchar2).Value = doctorName;
                checkSlotCmd.Parameters.Add(":date_value", OracleDbType.Varchar2).Value = date;
                checkSlotCmd.Parameters.Add(":start_time", OracleDbType.Varchar2).Value = startTime;

                int count = Convert.ToInt32(checkSlotCmd.ExecuteScalar());
                isAvailable = (count == 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking time slot: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isAvailable = false;
            }
            finally
            {
                con11.Close();
            }

            return isAvailable;
        }

        // Add this method to generate available time slots
        private List<string> GenerateTimeSlots(string startTime, string endTime)
        {
            List<string> timeSlots = new List<string>();

            // Parse start and end times
            DateTime start = DateTime.Parse(startTime);
            DateTime end = DateTime.Parse(endTime);

            // Generate 30-minute slots
            DateTime current = start;
            while (current.AddMinutes(30) <= end)
            {
                timeSlots.Add(current.ToString("hh:mm tt"));
                current = current.AddMinutes(30);
            }

            return timeSlots;
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

        // Modify your appoint_bnt_Click method
        private void appoint_bnt_Click(object sender, EventArgs e)
        {
            // Existing validation
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Select the Doctor first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Write Your disease first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if there's a schedule available
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No schedule available for this doctor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get schedule information from first row
            DataGridViewRow firstRow = dataGridView1.Rows[0];

            // Check if any of the cells contain null values
            if (firstRow.Cells["S_Time"].Value == null ||
                firstRow.Cells["E_Time"].Value == null ||
                firstRow.Cells["DAY"].Value == null)
            {
                MessageBox.Show("Doctor has no following schedule!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sTime = firstRow.Cells["S_Time"].Value.ToString();
            string eTime = firstRow.Cells["E_Time"].Value.ToString();
            string day = firstRow.Cells["DAY"].Value.ToString();

            // Check if selected date matches day in schedule
            DateTime selectedDate = dateTimePicker1.Value;
            string selectedDayOfWeek = selectedDate.DayOfWeek.ToString().ToUpper();

            if (selectedDayOfWeek != day.ToUpper())
            {
                MessageBox.Show($"Selected date ({selectedDate.ToString("dddd")}) doesn't match doctor's schedule day ({day}).",
                                "Date Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Generate available time slots for this doctor's schedule
            List<string> availableSlots = GenerateTimeSlots(sTime, eTime);

            // Show time slot selection dialog
            using (Form timeSlotForm = new Form())
            {
                timeSlotForm.Text = "Select Appointment Time";
                timeSlotForm.Size = new Size(300, 400);
                timeSlotForm.StartPosition = FormStartPosition.CenterParent;

                Label label = new Label() { Text = "Available Time Slots:", Location = new Point(20, 20) };
                timeSlotForm.Controls.Add(label);

                ListBox slotList = new ListBox() { Location = new Point(20, 50), Size = new Size(250, 250) };
                timeSlotForm.Controls.Add(slotList);

                string selectedDate_str = selectedDate.ToString("yyyy-MM-dd");

                // Populate list with available time slots
                foreach (string slot in availableSlots)
                {
                    if (IsTimeSlotAvailable(comboBox1.Text, selectedDate_str, slot))
                    {
                        slotList.Items.Add(slot);
                    }
                }

                if (slotList.Items.Count == 0)
                {
                    MessageBox.Show("No available time slots for this doctor on the selected date.",
                                   "No Availability", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                System.Windows.Forms.Button selectButton = new System.Windows.Forms.Button()
                {
                    Text = "Select",
                    DialogResult = DialogResult.OK,
                    Location = new Point(100, 320)
                };
                timeSlotForm.Controls.Add(selectButton);

                if (timeSlotForm.ShowDialog() == DialogResult.OK && slotList.SelectedItem != null)
                {
                    string selectedSlot = slotList.SelectedItem.ToString();

                    // Calculate end time (30 minutes after start)
                    DateTime startDateTime = DateTime.Parse(selectedSlot);
                    DateTime endDateTime = startDateTime.AddMinutes(30);
                    string calculatedEndTime = endDateTime.ToString("hh:mm tt");

                    // Get patient ID
                    int patient_Id = GetPatientIdFromName(Patient_Name);

                    // Insert appointment with the selected time slot
                    if (InsertAppointment(patient_Id, selectedSlot, calculatedEndTime, selectedDate_str,
                                         textBox1.Text, comboBox1.Text))
                    {
                        MessageBox.Show("Appointment successfully booked for " + selectedSlot + " - " + calculatedEndTime,
                                       "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Navigate back to patient view
                        this.Hide();
                        Patient_View form = new Patient_View(Patient_Name, Patient_Password);
                        form.Closed += (s, args) => form.Close();
                        form.Show();
                    }
                }
            }
        }


        // Helper method to get patient ID
        private int GetPatientIdFromName(string patientName)
        {
            int patientId = -1;

            try
            {
                con11.Open();
                OracleCommand getPatientIdCmd = con11.CreateCommand();
                getPatientIdCmd.CommandText = "SELECT ID FROM PATIENT WHERE NAME = :p_name";
                getPatientIdCmd.Parameters.Add("p_name", OracleDbType.Varchar2).Value = patientName;

                object result = getPatientIdCmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    patientId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting Patient ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con11.Close();
            }

            return patientId;
        }

        // Helper method to insert appointment
        private bool InsertAppointment(int patientId, string startTime, string endTime, string date,
                                      string disease, string doctorName)
        {
            bool success = false;

            try
            {
                con11.Open();
                OracleCommand insertCmd = con11.CreateCommand();
                insertCmd.CommandText = @"
            INSERT INTO APPOINTMENT (PATIENT_ID, S_TIME, E_TIME, STATUS, A_DATE, FEE, DISEASE, DOCTOR_NAME, A_ID)
            VALUES (:p_id, :starting_time, :ending_time, :status, TO_DATE(:date_value, 'YYYY-MM-DD'), 
                   :fee, :disease, :doctor_name, A_ID.NEXTVAL)";

                insertCmd.Parameters.Add(":p_id", OracleDbType.Int32).Value = patientId;
                insertCmd.Parameters.Add(":starting_time", OracleDbType.Varchar2).Value = startTime;
                insertCmd.Parameters.Add(":ending_time", OracleDbType.Varchar2).Value = endTime;
                insertCmd.Parameters.Add(":status", OracleDbType.Varchar2).Value = "PENDING";
                insertCmd.Parameters.Add(":date_value", OracleDbType.Varchar2).Value = date;
                insertCmd.Parameters.Add(":fee", OracleDbType.Decimal).Value = FEE;
                insertCmd.Parameters.Add(":disease", OracleDbType.Varchar2).Value = disease;
                insertCmd.Parameters.Add(":doctor_name", OracleDbType.Varchar2).Value = doctorName;

                int rows = insertCmd.ExecuteNonQuery();
                success = (rows > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error booking appointment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con11.Close();
            }

            return success;
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
