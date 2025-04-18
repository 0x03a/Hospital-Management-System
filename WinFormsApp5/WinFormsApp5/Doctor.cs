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

        private bool IsValidEmail(string email)
        {
            try
            {
                // Use .NET's built-in validation or regex for email format
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

                    DialogResult result = MessageBox.Show("Are you sure you want to update this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes )
           
                    {

                        try
                        {


                            con4.Open();
                            // check email if they exist doctor and in another table 
                            OracleCommand cmdGetOriginalEmail = con4.CreateCommand();
                            cmdGetOriginalEmail.CommandText = "SELECT Email FROM DOCTORS WHERE  email = :demail";
                            cmdGetOriginalEmail.Parameters.Add("demail", OracleDbType.Varchar2).Value = email;


                            int Dmail = Convert.ToInt32(cmdGetOriginalEmail.ExecuteScalar());



                            cmdGetOriginalEmail.CommandText = "SELECT Email FROM PATIENT WHERE  email = :demail";
                            int Pmail = Convert.ToInt32(cmdGetOriginalEmail.ExecuteScalar());



                            cmdGetOriginalEmail.CommandText = "SELECT Email FROM NURSE WHERE  email = :demail";

                            int Nmail = Convert.ToInt32(cmdGetOriginalEmail.ExecuteScalar());


                            cmdGetOriginalEmail.CommandText = "SELECT Email RECEPTIONIST WHERE  email = :demail";

                            int Rmail = Convert.ToInt32(cmdGetOriginalEmail.ExecuteScalar());

                            con4.Close();


                            con4.Open();



                            // check password if they exist doctor and in another table 
                            OracleCommand cmdCheckPassword = con4.CreateCommand();


                            cmdCheckPassword.CommandText = "SELECT COUNT(*) FROM PATIENT WHERE Password = :password1";
                            // once a parameter in this case is added you don't need to add it again.
                            cmdCheckPassword.Parameters.Add(":password1", OracleDbType.Varchar2).Value = password;

                            int patientPasswordCount = Convert.ToInt32(cmdCheckPassword.ExecuteScalar());



                            cmdCheckPassword.CommandText = "SELECT COUNT(*) FROM NURSE WHERE Password = :password1";
                        
                            int NursePasswordCount = Convert.ToInt32(cmdCheckPassword.ExecuteScalar());


                            cmdCheckPassword.CommandText = "SELECT COUNT(*) FROM RECEPTIONIST WHERE Password = :password1";
                           
                            int ReceptionistPasswordCount = Convert.ToInt32(cmdCheckPassword.ExecuteScalar());


                            cmdCheckPassword.CommandText = "SELECT COUNT(*) FROM Doctors WHERE Password = :password1";
                           

                            int doctorPasswordCount = Convert.ToInt32(cmdCheckPassword.ExecuteScalar());



                           







                            if (patientPasswordCount == 0 && NursePasswordCount ==0 && ReceptionistPasswordCount ==0 && doctorPasswordCount == 0  ) 
                            {
                           /*     // No match found in the patient table, proceed with the update
                                OracleCommand cmdSelect = con4.CreateCommand();
                                cmdSelect.CommandText = "SELECT COUNT(*) FROM DOCTORS WHERE Name = :UpdatedName AND id != :Doctor_id";
                                cmdSelect.Parameters.Add("UpdatedName", OracleDbType.Varchar2).Value = name;
                                cmdSelect.Parameters.Add("Doctor_id", OracleDbType.Int64).Value = DOCTOR_idd;
*/
                               /* int existingCount = Convert.ToInt32(cmdSelect.ExecuteScalar());*/
/*
                                if (existingCount == 0)
                                {*/
                                    // The updated name doesn't exist in the DOCTORS table
                                    OracleCommand cmdUpdate = con4.CreateCommand();
                                    cmdUpdate.CommandText = "UPDATE DOCTORS SET Name = :Name, Password = :Password1, Email = :Email, Qualification = :Qualification, Gender = :Gender, Salary = :Salary WHERE id = :Doctor_id";
                                    cmdUpdate.Parameters.Add(":Name", OracleDbType.Varchar2).Value = name;
                                    cmdUpdate.Parameters.Add(":Password1", OracleDbType.Varchar2).Value = password;
                                    cmdUpdate.Parameters.Add(":Email", OracleDbType.Varchar2).Value = email;
                                    cmdUpdate.Parameters.Add(":Qualification", OracleDbType.Varchar2).Value = qualification;
                                    cmdUpdate.Parameters.Add(":Gender", OracleDbType.Varchar2).Value = gender;
                                    cmdUpdate.Parameters.Add(":Salary", OracleDbType.Decimal).Value = salary;
                                    cmdUpdate.Parameters.Add(":Doctor_id", OracleDbType.Int64).Value = DOCTOR_idd;

                                    int rowsAffected = cmdUpdate.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        con4.Close();
                                        updateGrid(); // Refresh the DataGridView
                                    }
                                    else
                                    {
                                        MessageBox.Show("No records updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        con4.Close();
                                        updateGrid(); // Refresh the DataGridView
                                    }
                              /*  }
                                else
                                {
                                    // The updated name already exists in the DOCTORS table
                                    MessageBox.Show("The updated name already exists in the table. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }*/
                            }
                            else
                            {

                                // Password match found in the patient table
                                MessageBox.Show(" Please choose a different.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                con4.Close();
                            }
                        }
                        catch (Exception ex)
                        {


                            MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con4.Close();
                        }
                        finally
                        {
                            con4.Close();
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
                object sTimeObject, eTimeObject, dayObject, doctor_Id;
                sTimeObject = dataGridView2.Rows[e.RowIndex].Cells["S_TIME"].Value;
                eTimeObject = dataGridView2.Rows[e.RowIndex].Cells["E_TIME"].Value;
                dayObject = dataGridView2.Rows[e.RowIndex].Cells["DAY"].Value;
                doctor_Id = dataGridView2.Rows[e.RowIndex].Cells["DOCTOR_ID"].Value;
                // Check for DBNull values and handle them appropriately
                if ((sTimeObject == DBNull.Value || sTimeObject == null) ||
                    (eTimeObject == DBNull.Value || eTimeObject == null) ||
                (dayObject == DBNull.Value || dayObject == null) ||
                    (doctor_Id == DBNull.Value || doctor_Id == null))
                {
                    MessageBox.Show("Please fill all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the clicked cell is the button column and the button column is not the header
                if (dataGridView2.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    // Check if there are any records in the DataGridView
                    if (dataGridView2.Rows.Count == 0)
                    {
                        MessageBox.Show("No records found to Insert, delete, and Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Get the doctor ID from the clicked row in DataGridView2
                    int doctorId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["DOCTOR_ID"].Value);

                    // Check if the doctor ID exists in the Doctor table
                    if (DoctorExists(doctorId))
                    {
                        // If the doctor exists, proceed with inserting the data
                        string sTime = Convert.ToString(sTimeObject);
                        string eTime = Convert.ToString(eTimeObject);
                        string day = Convert.ToString(dayObject);

                        try
                        {
                            con4.Open();
                            OracleCommand cmd = con4.CreateCommand();
                            cmd.CommandText = "INSERT INTO SCHEDULE (S_ID, S_TIME, E_TIME, DAY, DOCTOR_ID) VALUES (S_ID.NEXTVAL, :S_TIME, :E_TIME, :DAY, :DOCTOR_ID)";

                            cmd.Parameters.Add(":S_TIME", OracleDbType.Varchar2).Value = sTime;
                            cmd.Parameters.Add(":E_TIME", OracleDbType.Varchar2).Value = eTime;
                            cmd.Parameters.Add(":DAY", OracleDbType.Varchar2).Value = day;
                            cmd.Parameters.Add(":DOCTOR_ID", OracleDbType.Int32).Value = doctorId;

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                con4.Close();
                                updateGrid(); // Refresh the DataGridView
                            }
                            else
                            {
                                MessageBox.Show("No records inserted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                con4.Close();
                                updateGrid(); // Refresh the DataGridView
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error inserting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            con4.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Doctor with ID " + doctorId + " does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("DATA cannot be Inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.ColumnIndex == dataGridView2.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                object value = dataGridView2.Rows[e.RowIndex].Cells["S_ID"].Value;
                if (value != null && value != DBNull.Value)
                {
                    long scheduleId = Convert.ToInt64(value);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        con4.Open();
                        OracleCommand deleteScheduleCmd = con4.CreateCommand();
                        deleteScheduleCmd.CommandText = "DELETE FROM SCHEDULE WHERE S_ID = :ScheduleId";
                        deleteScheduleCmd.Parameters.Add("ScheduleId", OracleDbType.Int64).Value = scheduleId;
                        deleteScheduleCmd.CommandType = CommandType.Text;
                        int rowsAffected = deleteScheduleCmd.ExecuteNonQuery();
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
                    MessageBox.Show("Selected row does not contain a valid Schedule ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



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
