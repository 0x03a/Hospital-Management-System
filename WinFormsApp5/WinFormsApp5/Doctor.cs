using Microsoft.AspNetCore.Identity;
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
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography.Xml;

namespace WinFormsApp5
{
    public partial class Doctor : Form
    {
        OracleConnection con4;
        public Doctor()
        {
            InitializeComponent();
            // maximizing the Window
            this.WindowState = FormWindowState.Maximized;

        }




        private void Doctor_Load(object sender, EventArgs e)
        {

            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=INSHALLL;PASSWORD=progr@mmer";
            con4 = new OracleConnection(conStr);

            updateGrid();
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;



        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // back to admin page (form2)
            Form2 form = new Form2();
            this.Hide();
            form.Closed += (s, args) => form.Close();
            form.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // back to login page
            Form1 form = new Form1();
            this.Hide();
            form.Closed += (s, args) => form.Close();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // it should open add Doctors page
            Add_Doctors form = new Add_Doctors();
            this.Hide();
            form.Closed += (s, args) => form.Close();
            form.Show();
        }

        // Replace your current IsValidEmail method with this more robust version
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Basic structure check
                int atIndex = email.IndexOf('@');
                if (atIndex <= 0 || atIndex == email.Length - 1)
                    return false;

                // Local part and domain part
                string localPart = email.Substring(0, atIndex);
                string domainPart = email.Substring(atIndex + 1);

                // Local part validation
                if (localPart.Length > 64)
                    return false;

                // Check for invalid characters in local part
                string invalidLocalChars = "(),:;<>@[\\]";
                foreach (char c in invalidLocalChars)
                {
                    if (localPart.Contains(c))
                        return false;
                }

                // Check if local part starts or ends with a dot
                if (localPart.StartsWith(".") || localPart.EndsWith("."))
                    return false;

                // Check if local part has consecutive dots
                if (localPart.Contains(".."))
                    return false;

                // Domain part validation
                if (domainPart.Length > 255)
                    return false;

                // Domain must have at least one dot
                if (!domainPart.Contains("."))
                    return false;

                // Domain must not start or end with a dot or hyphen
                if (domainPart.StartsWith(".") || domainPart.EndsWith(".") ||
                    domainPart.StartsWith("-") || domainPart.EndsWith("-"))
                    return false;

                // Domain parts validation
                string[] domainParts = domainPart.Split('.');
                foreach (string part in domainParts)
                {
                    // Each domain part must not be empty
                    if (string.IsNullOrEmpty(part))
                        return false;

                    // Domain parts must only contain letters, numbers, and hyphens
                    foreach (char c in part)
                    {
                        if (!char.IsLetterOrDigit(c) && c != '-')
                            return false;
                    }

                    // Domain parts must not have consecutive hyphens
                    if (part.Contains("--"))
                        return false;
                }

                // Top-level domain validation
                string tld = domainParts[domainParts.Length - 1];
                if (tld.Length < 2)
                    return false;

                // Final verification with .NET's MailAddress
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void updateGrid()

        {


            con4.Open();
            OracleCommand getEmps = con4.CreateCommand();
            getEmps.CommandText = "SELECT * FROM DOCTORS";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);

            dataGridView1.DataSource = empDT;

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.HeaderText = "Delete";
            deleteButton.Name = "delete";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Text = "Delete";
            deleteButton.Width = 100;

            if (!dataGridView1.Columns.Contains("delete"))
            {
                dataGridView1.Columns.Add(deleteButton);
            }
            con4.Close();

            con4.Open();

            OracleCommand getEmps2 = con4.CreateCommand();
            getEmps2.CommandText = "SELECT * FROM DOCTORS";
            getEmps2.CommandType = CommandType.Text;
            OracleDataReader empDR2 = getEmps2.ExecuteReader();
            DataTable empDT2 = new DataTable();
            empDT2.Load(empDR2);

            dataGridView1.DataSource = empDT2;

            DataGridViewButtonColumn updateButton2 = new DataGridViewButtonColumn();
            updateButton2.FlatStyle = FlatStyle.Popup;
            updateButton2.HeaderText = "Update";
            updateButton2.Name = "Update";
            updateButton2.UseColumnTextForButtonValue = true;
            updateButton2.Text = "Update";
            updateButton2.Width = 100;

            if (!dataGridView1.Columns.Contains("Update"))
            {
                dataGridView1.Columns.Add(updateButton2);
            }

            con4.Close();


            con4.Open();

            OracleCommand getEmps3 = con4.CreateCommand();
            getEmps3.CommandText = "SELECT * FROM SCHEDULE";
            getEmps3.CommandType = CommandType.Text;
            OracleDataReader empDR3 = getEmps3.ExecuteReader();
            DataTable empDT3 = new DataTable();
            empDT3.Load(empDR3);

            dataGridView2.DataSource = empDT3;

            DataGridViewButtonColumn Select_button = new DataGridViewButtonColumn();
            Select_button.FlatStyle = FlatStyle.Popup;
            Select_button.HeaderText = "Set_Schedule";
            Select_button.Name = "Insert";
            Select_button.UseColumnTextForButtonValue = true;
            Select_button.Text = "Insert";
            Select_button.Width = 100;

            if (!dataGridView2.Columns.Contains("Insert"))
            {
                dataGridView2.Columns.Add(Select_button);
            }

            con4.Close();



            con4.Open();

            OracleCommand getEmps4 = con4.CreateCommand();
            getEmps4.CommandText = "SELECT * FROM SCHEDULE";
            getEmps4.CommandType = CommandType.Text;
            OracleDataReader empDR4 = getEmps4.ExecuteReader();
            DataTable empDT4 = new DataTable();
            empDT4.Load(empDR4);

            dataGridView2.DataSource = empDT3;


            // Create a DataGridViewButtonColumn for delete operation
            DataGridViewButtonColumn Delete_button = new DataGridViewButtonColumn();
            Delete_button.FlatStyle = FlatStyle.Popup;
            Delete_button.HeaderText = "Delete_Schedule";
            Delete_button.Name = "Delete";
            Delete_button.UseColumnTextForButtonValue = true;
            Delete_button.Text = "Delete";
            Delete_button.Width = 100;

            // Check if the DataGridView already contains a column for Delete_Schedule
            if (!dataGridView2.Columns.Contains("Delete"))
            {
                dataGridView2.Columns.Add(Delete_button);
            }

            con4.Close();





        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No records found to delete, and update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //{
            //    string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            //    MessageBox.Show($"Clicked column: {columnName}, Index: {e.ColumnIndex}");
            //}

            if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;
                if (value != DBNull.Value && value != null)
                {
                    long DOCTOR_idd = Convert.ToInt64(value);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        con4.Open();
                        OracleCommand getEmps = con4.CreateCommand();
                        getEmps.CommandText = "DELETE FROM DOCTORS WHERE id = :Doctor_idd";
                        getEmps.Parameters.Add("Doctor_idd", OracleDbType.Int64).Value = DOCTOR_idd; // Add parameter if Doctor_idd is of a different type
                        getEmps.CommandType = CommandType.Text;
                        int rowsAffected = getEmps.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con4.Close();
                            updateGrid(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con4.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Selected row does not contain a valid Doctor ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Revised Update button handler inside dataGridView1_CellContentClick
            else if (e.ColumnIndex == dataGridView1.Columns["Update"].Index && e.RowIndex >= 0)
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;
                if (value != DBNull.Value && value != null)
                {
                    long DOCTOR_idd = Convert.ToInt64(value);

                    // Get values for update from DataGridView
                    string name = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Name"].Value);
                    string password = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Password"].Value);
                    string email = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Email"].Value);
                    string qualification = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Qualification"].Value);
                    string gender = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value);
                    float salary = Convert.ToSingle(dataGridView1.Rows[e.RowIndex].Cells["Salary"].Value);

                    // Validate email format first before proceeding
                    if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
                    {
                        MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        updateGrid();
                        return;
                    }

                    DialogResult result = MessageBox.Show("Are you sure you want to update this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            con4.Open();

                            // Get the original email for this doctor to check if it's being changed
                            OracleCommand cmdGetOriginalEmail = con4.CreateCommand();
                            cmdGetOriginalEmail.CommandText = "SELECT Email FROM DOCTORS WHERE ID = :doctorId";
                            cmdGetOriginalEmail.Parameters.Add("doctorId", OracleDbType.Int64).Value = DOCTOR_idd;
                            string originalEmail = Convert.ToString(cmdGetOriginalEmail.ExecuteScalar());

                            // Only check for email uniqueness if the email is being changed
                            bool emailChanged = !string.Equals(originalEmail, email, StringComparison.OrdinalIgnoreCase);

                            if (emailChanged)
                            {
                                // Check if email exists in any table
                                bool emailExists = false;

                                // Check in DOCTORS table (excluding current doctor)
                                cmdGetOriginalEmail.CommandText = "SELECT COUNT(*) FROM DOCTORS WHERE Email = :email AND ID != :doctorId";
                                cmdGetOriginalEmail.Parameters.Clear();
                                cmdGetOriginalEmail.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
                                cmdGetOriginalEmail.Parameters.Add("doctorId", OracleDbType.Int64).Value = DOCTOR_idd;
                                int doctorEmailCount = Convert.ToInt32(cmdGetOriginalEmail.ExecuteScalar());
                                emailExists = doctorEmailCount > 0;

                                // Check in PATIENT table
                                if (!emailExists)
                                {
                                    cmdGetOriginalEmail.CommandText = "SELECT COUNT(*) FROM PATIENT WHERE Email = :email";
                                    cmdGetOriginalEmail.Parameters.Clear();
                                    cmdGetOriginalEmail.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
                                    int patientEmailCount = Convert.ToInt32(cmdGetOriginalEmail.ExecuteScalar());
                                    emailExists = patientEmailCount > 0;
                                }

                                // Check in NURSE table
                                if (!emailExists)
                                {
                                    cmdGetOriginalEmail.CommandText = "SELECT COUNT(*) FROM NURSE WHERE Email = :email";
                                    cmdGetOriginalEmail.Parameters.Clear();
                                    cmdGetOriginalEmail.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
                                    int nurseEmailCount = Convert.ToInt32(cmdGetOriginalEmail.ExecuteScalar());
                                    emailExists = nurseEmailCount > 0;
                                }

                                // Check in RECEPTIONIST table
                                if (!emailExists)
                                {
                                    cmdGetOriginalEmail.CommandText = "SELECT COUNT(*) FROM RECEPTIONIST WHERE Email = :email";
                                    cmdGetOriginalEmail.Parameters.Clear();
                                    cmdGetOriginalEmail.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
                                    int receptionistEmailCount = Convert.ToInt32(cmdGetOriginalEmail.ExecuteScalar());
                                    emailExists = receptionistEmailCount > 0;
                                }

                                if (emailExists)
                                {
                                    MessageBox.Show("This email address is already in use. Please choose a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    con4.Close();
                                    return;
                                }
                            }

                            // Check if password is unique (if necessary)
                            OracleCommand cmdCheckPassword = con4.CreateCommand();
                            cmdCheckPassword.CommandText = "SELECT COUNT(*) FROM DOCTORS WHERE Password = :password AND ID != :doctorId";
                            cmdCheckPassword.Parameters.Add("password", OracleDbType.Varchar2).Value = password;
                            cmdCheckPassword.Parameters.Add("doctorId", OracleDbType.Int64).Value = DOCTOR_idd;
                            int doctorPasswordCount = Convert.ToInt32(cmdCheckPassword.ExecuteScalar());

                            cmdCheckPassword.CommandText = "SELECT COUNT(*) FROM PATIENT WHERE Password = :password";
                            cmdCheckPassword.Parameters.Clear();
                            cmdCheckPassword.Parameters.Add("password", OracleDbType.Varchar2).Value = password;
                            int patientPasswordCount = Convert.ToInt32(cmdCheckPassword.ExecuteScalar());

                            cmdCheckPassword.CommandText = "SELECT COUNT(*) FROM NURSE WHERE Password = :password";
                            cmdCheckPassword.Parameters.Clear();
                            cmdCheckPassword.Parameters.Add("password", OracleDbType.Varchar2).Value = password;
                            int nursePasswordCount = Convert.ToInt32(cmdCheckPassword.ExecuteScalar());

                            cmdCheckPassword.CommandText = "SELECT COUNT(*) FROM RECEPTIONIST WHERE Password = :password";
                            cmdCheckPassword.Parameters.Clear();
                            cmdCheckPassword.Parameters.Add("password", OracleDbType.Varchar2).Value = password;
                            int receptionistPasswordCount = Convert.ToInt32(cmdCheckPassword.ExecuteScalar());

                            bool passwordExists = doctorPasswordCount > 0 || patientPasswordCount > 0 ||
                                                nursePasswordCount > 0 || receptionistPasswordCount > 0;

                            if (passwordExists)
                            {
                                MessageBox.Show("This password is already in use. Please choose a different password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                con4.Close();
                                return;
                            }

                            // All checks passed, proceed with the update
                            OracleCommand cmdUpdate = con4.CreateCommand();
                            cmdUpdate.CommandText = "UPDATE DOCTORS SET Name = :Name, Password = :Password, Email = :Email, " +
                                                    "Qualification = :Qualification, Gender = :Gender, Salary = :Salary " +
                                                    "WHERE ID = :DoctorId";

                            cmdUpdate.Parameters.Add("Name", OracleDbType.Varchar2).Value = name;
                            cmdUpdate.Parameters.Add("Password", OracleDbType.Varchar2).Value = password;
                            cmdUpdate.Parameters.Add("Email", OracleDbType.Varchar2).Value = email;
                            cmdUpdate.Parameters.Add("Qualification", OracleDbType.Varchar2).Value = qualification;
                            cmdUpdate.Parameters.Add("Gender", OracleDbType.Varchar2).Value = gender;
                            cmdUpdate.Parameters.Add("Salary", OracleDbType.Decimal).Value = salary;
                            cmdUpdate.Parameters.Add("DoctorId", OracleDbType.Int64).Value = DOCTOR_idd;

                            int rowsAffected = cmdUpdate.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No records updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (con4.State == ConnectionState.Open)
                                con4.Close();
                            updateGrid(); // Refresh the DataGridView
                        }
                    }
                }
            }



        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Nurse button
            // will open Nurse Page
            Nurse form = new Nurse();
            this.Hide();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receptionist form = new Receptionist();
            form.Closed += (s, args) => form.Close();
            form.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["Insert"].Index && e.RowIndex >= 0)
            {
                // Instead of reading from grid cells, let's prompt the user for input
                using (Form inputForm = new Form())
                {
                    inputForm.Text = "Schedule Details";
                    inputForm.Size = new Size(400, 300);
                    inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                    inputForm.StartPosition = FormStartPosition.CenterParent;
                    inputForm.MaximizeBox = false;
                    inputForm.MinimizeBox = false;

                    // Add doctor ID input
                    Label lblDoctorId = new Label();
                    lblDoctorId.Text = "Doctor ID:";
                    lblDoctorId.SetBounds(20, 20, 100, 20);
                    inputForm.Controls.Add(lblDoctorId);

                    TextBox txtDoctorId = new TextBox();
                    txtDoctorId.SetBounds(130, 20, 200, 20);
                    inputForm.Controls.Add(txtDoctorId);

                    // Add start time input
                    Label lblStartTime = new Label();
                    lblStartTime.Text = "Start Time:";
                    lblStartTime.SetBounds(20, 60, 100, 20);
                    inputForm.Controls.Add(lblStartTime);

                    TextBox txtStartTime = new TextBox();
                    txtStartTime.SetBounds(130, 60, 200, 20);
                    txtStartTime.PlaceholderText = "e.g. 09:00 AM";
                    inputForm.Controls.Add(txtStartTime);

                    // Add end time input
                    Label lblEndTime = new Label();
                    lblEndTime.Text = "End Time:";
                    lblEndTime.SetBounds(20, 100, 100, 20);
                    inputForm.Controls.Add(lblEndTime);

                    TextBox txtEndTime = new TextBox();
                    txtEndTime.SetBounds(130, 100, 200, 20);
                    txtEndTime.PlaceholderText = "e.g. 05:00 PM";
                    inputForm.Controls.Add(txtEndTime);

                    // Add day input
                    Label lblDay = new Label();
                    lblDay.Text = "Day:";
                    lblDay.SetBounds(20, 140, 100, 20);
                    inputForm.Controls.Add(lblDay);

                    ComboBox cmbDay = new ComboBox();
                    cmbDay.SetBounds(130, 140, 200, 20);
                    cmbDay.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmbDay.Items.AddRange(new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
                    inputForm.Controls.Add(cmbDay);

                    // Add Save button
                    Button btnSave = new Button();
                    btnSave.Text = "Save";
                    btnSave.DialogResult = DialogResult.OK;
                    btnSave.SetBounds(130, 180, 75, 30);
                    inputForm.Controls.Add(btnSave);

                    // Add Cancel button
                    Button btnCancel = new Button();
                    btnCancel.Text = "Cancel";
                    btnCancel.DialogResult = DialogResult.Cancel;
                    btnCancel.SetBounds(230, 180, 75, 30);
                    inputForm.Controls.Add(btnCancel);

                    // Set default button and show the form
                    inputForm.AcceptButton = btnSave;
                    inputForm.CancelButton = btnCancel;

                    DialogResult result = inputForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        // Validate all inputs are provided
                        if (string.IsNullOrWhiteSpace(txtDoctorId.Text) ||
                            string.IsNullOrWhiteSpace(txtStartTime.Text) ||
                            string.IsNullOrWhiteSpace(txtEndTime.Text) ||
                            cmbDay.SelectedIndex == -1)
                        {
                            MessageBox.Show("All fields are required. Please complete all information.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Validate doctor ID is numeric
                        if (!int.TryParse(txtDoctorId.Text, out int doctorId))
                        {
                            MessageBox.Show("Doctor ID must be a valid number.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Check if the doctor exists
                        if (!DoctorExists(doctorId))
                        {
                            MessageBox.Show($"Doctor with ID {doctorId} does not exist.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string startTime = txtStartTime.Text;
                        string endTime = txtEndTime.Text;
                        string day = cmbDay.SelectedItem.ToString();

                        try
                        {
                            con4.Open();
                            OracleCommand cmd = con4.CreateCommand();
                            cmd.CommandText = "INSERT INTO SCHEDULE (S_ID, S_TIME, E_TIME, DAY, DOCTOR_ID) " +
                                              "VALUES (S_ID.NEXTVAL, :S_TIME, :E_TIME, :DAY, :DOCTOR_ID)";

                            cmd.Parameters.Add(":S_TIME", OracleDbType.Varchar2).Value = startTime;
                            cmd.Parameters.Add(":E_TIME", OracleDbType.Varchar2).Value = endTime;
                            cmd.Parameters.Add(":DAY", OracleDbType.Varchar2).Value = day;
                            cmd.Parameters.Add(":DOCTOR_ID", OracleDbType.Int32).Value = doctorId;

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Schedule added successfully.",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                con4.Close();
                                updateGrid(); // Refresh the DataGridView

                            }
                            else
                            {
                                MessageBox.Show("Failed to add schedule.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                con4.Close();
                                updateGrid(); // Refresh the DataGridView
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error inserting schedule: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con4.Close();
                            updateGrid(); // Refresh the DataGridView
                        }
                        finally
                        {
                            if (con4.State == ConnectionState.Open)
                                con4.Close();
                        }
                    }
                }
            }
            else if (e.ColumnIndex == dataGridView2.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // The delete functionality seems fine, but let's improve error handling
                object value = dataGridView2.Rows[e.RowIndex].Cells["S_ID"].Value;
                if (value != null && value != DBNull.Value)
                {
                    long scheduleId = Convert.ToInt64(value);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this schedule?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            con4.Open();
                            OracleCommand deleteScheduleCmd = con4.CreateCommand();
                            deleteScheduleCmd.CommandText = "DELETE FROM SCHEDULE WHERE S_ID = :ScheduleId";
                            deleteScheduleCmd.Parameters.Add("ScheduleId", OracleDbType.Int64).Value = scheduleId;

                            int rowsAffected = deleteScheduleCmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Schedule deleted successfully.",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                con4.Close();
                                updateGrid(); // Refresh the DataGridView
                                
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete schedule.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                con4.Close();
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting schedule: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con4.Close();
                        }
                        finally
                        {
                            if (con4.State == ConnectionState.Open)
                                con4.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selected row does not contain a valid Schedule ID.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con4.Close();
                }
                con4.Close();
            }
        }


        // Function to check if a doctor exists in the Doctor table
        private bool DoctorExists(int doctorId)
        {
            try
            {
                con4.Open();
                OracleCommand cmd = con4.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM DOCTORS WHERE id = :Doctor_idd";
                cmd.Parameters.Add("Doctor_idd", OracleDbType.Int32).Value = doctorId;

                // Let's check what the count value is before conversion
                object result = cmd.ExecuteScalar();
                int count = Convert.ToInt32(result);
                con4.Close();
                return count > 0;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking doctor existence: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con4.Close();
                return false;
            }
            finally
            {
                con4.Close();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the cell being formatted is a header cell
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                // Set the background color of the column header to black
                e.CellStyle.BackColor = Color.Black;

                // Set the foreground color (text color) of the column header to white
                e.CellStyle.ForeColor = Color.White;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Patient Button
            // Go to the Patient Page in admin
            this.Hide();
            PatientinAdmin form1 = new PatientinAdmin();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }
    }
}
