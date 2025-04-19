using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace WinFormsApp5
{
    public partial class Nurse : Form
    {
        OracleConnection con7;
        public Nurse()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Adding Nurse
            Add_Nurse form = new Add_Nurse();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Go to the Doctors Page
            // Doctor button
            Doctor form = new Doctor();
            this.Hide();
            form.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Patient button
            // Go to the Patient Page
            PatientinAdmin form = new PatientinAdmin();
            this.Hide();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Go to the Appointments page
            //  Appointment button
            this.Hide();
            Total_Appointments_IN_Admin form1 = new Total_Appointments_IN_Admin();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Nurse button
            // Go to the Admin Page
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // update Nurse
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Receptionist Button
            this.Hide();
            Receptionist form = new Receptionist();
            form.Closed += (s, args) => form.Close();
            form.Show();
        }

        private void Nurse_Load(object sender, EventArgs e)
        {
            // Connection here
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=INSHALLL;PASSWORD=progr@mmer";
            con7 = new OracleConnection(conStr);
            updateGrid();// for showing the Nurse records
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            // Set the font style of column headers to bold
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

        }

        private void updateGrid()// for viewing the records
        {
            con7.Open();
            OracleCommand getEmps = con7.CreateCommand();
            getEmps.CommandText = "SELECT * FROM NURSE";
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

            con7.Close();



            con7.Open();

            OracleCommand getEmps2 = con7.CreateCommand();
            getEmps2.CommandText = "SELECT * FROM NURSE";
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

            con7.Close();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
                    MessageBox.Show($"Clicked column: {columnName}, Index: {e.ColumnIndex}");
                }


                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No records found to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
                {
                    object value = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;
                    if (value != DBNull.Value && value != null)
                    {
                        long Nurse_idd = Convert.ToInt64(value);

                        DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            con7.Open();
                            OracleCommand getEmps = con7.CreateCommand();
                            getEmps.CommandText = "DELETE FROM NURSE WHERE id = :Nurse_idd";
                            getEmps.Parameters.Add("Nurse_idd", OracleDbType.Int64).Value = Nurse_idd; // Add parameter if Nurse_idd is of a different type
                            getEmps.CommandType = CommandType.Text;
                            int rowsAffected = getEmps.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                con7.Close();
                                updateGrid(); // Refresh the DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            con7.Close();
                        }
                    }
                }
                else if (e.ColumnIndex == dataGridView1.Columns["Update"].Index && e.RowIndex >= 0)
                {

                    object value2 = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;
                    if (value2 != DBNull.Value && value2 != null)
                    {
                        long NURSE_idd = Convert.ToInt64(value2);

                    /*    // Get values for update from DataGridView
                        string name = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Name"].Value);
                        string password = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Password"].Value);
                        string email = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Email"].Value);
                        string qualification = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Qualification"].Value);
                        string gender = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value);
                    float salary = Convert.ToSingle(dataGridView1.Rows[e.RowIndex].Cells["Salary"].Value);
*/

                    // Get values for update from DataGridView
                    string name = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Name"].Value);
                    string password = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Password"].Value);
                    string email = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Email"].Value);
                    string qualification = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Qualification"].Value);
                    string gender = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value);

                    // Validate email format first before proceeding
                    if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
                    {
                        MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        updateGrid();
                        return;
                    }
                    // Validate salary format
                    float salary;
                    if (!float.TryParse(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Salary"].Value), out salary))
                    {
                        MessageBox.Show("Invalid salary format. Please enter a valid number.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Continue with your existing code for the update...

                    DialogResult result = MessageBox.Show("Are you sure you want to update this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            try
                            {



                                con7.Open();

                                OracleCommand cmdGetOriginalEmail = con7.CreateCommand();
                                cmdGetOriginalEmail.CommandText = "SELECT  COUNT(*) FROM DOCTORS WHERE  email = :demail";
                                cmdGetOriginalEmail.Parameters.Clear();
                                cmdGetOriginalEmail.Parameters.Add("demail", OracleDbType.Varchar2).Value = email;


                                int Dmail = Convert.ToInt32(cmdGetOriginalEmail.ExecuteScalar());





                                cmdGetOriginalEmail.CommandText = "SELECT COUNT(*) FROM PATIENT WHERE  email = :demail";
                                cmdGetOriginalEmail.Parameters.Clear();

                                cmdGetOriginalEmail.Parameters.Add("demail", OracleDbType.Varchar2).Value = email;
                                int Pmail = Convert.ToInt32(cmdGetOriginalEmail.ExecuteScalar());


                                cmdGetOriginalEmail.CommandText = "SELECT  COUNT(*) FROM NURSE WHERE  email = :demail AND id != :currentID";
                                cmdGetOriginalEmail.Parameters.Clear();

                                cmdGetOriginalEmail.Parameters.Add("demail", OracleDbType.Varchar2).Value = email;
                                cmdGetOriginalEmail.Parameters.Add("currentID", OracleDbType.Varchar2).Value = NURSE_idd;
                                int Nmail = Convert.ToInt32(cmdGetOriginalEmail.ExecuteScalar());



                                cmdGetOriginalEmail.CommandText = "SELECT  COUNT(*) FROM RECEPTIONIST WHERE  email = :demail";
                                cmdGetOriginalEmail.Parameters.Clear();

                                cmdGetOriginalEmail.Parameters.Add("demail", OracleDbType.Varchar2).Value = email;
                                int Rmail = Convert.ToInt32(cmdGetOriginalEmail.ExecuteScalar());





                                con7.Close();




                                con7.Open();
                                OracleCommand cmdSelect = con7.CreateCommand();

                                // First check
                                cmdSelect.CommandText = "SELECT COUNT(*) FROM NURSE WHERE Name = :UpdatedName AND id != :NURSE_id";
                                cmdSelect.Parameters.Clear();
                                cmdSelect.Parameters.Add("UpdatedName", OracleDbType.Varchar2).Value = name;
                                cmdSelect.Parameters.Add("NURSE_id", OracleDbType.Int64).Value = NURSE_idd;
                                int existingCount = Convert.ToInt32(cmdSelect.ExecuteScalar());

                                // Second check
                                cmdSelect.CommandText = "SELECT COUNT(*) FROM RECEPTIONIST WHERE password = :pass1";
                                cmdSelect.Parameters.Clear();
                                cmdSelect.Parameters.Add("pass1", OracleDbType.Varchar2).Value = password;
                                int patientPasswordCount = Convert.ToInt32(cmdSelect.ExecuteScalar());

                                // Third check - Check if password exists for any OTHER nurse (excluding the current one)
                                cmdSelect.CommandText = "SELECT COUNT(*) FROM NURSE WHERE Password = :pass1 AND ID != :currentID";
                                cmdSelect.Parameters.Clear();
                                cmdSelect.Parameters.Add("pass1", OracleDbType.Varchar2).Value = password;
                                cmdSelect.Parameters.Add("currentID", OracleDbType.Int64).Value = NURSE_idd;
                                int NursePasswordCount = Convert.ToInt32(cmdSelect.ExecuteScalar());

                                // Fourth check  
                                cmdSelect.CommandText = "SELECT COUNT(*) FROM RECEPTIONIST WHERE Password = :pass1";
                                cmdSelect.Parameters.Clear();
                                cmdSelect.Parameters.Add("pass1", OracleDbType.Varchar2).Value = password;
                                int ReceptionistPasswordCount = Convert.ToInt32(cmdSelect.ExecuteScalar());

                                // Fifth check
                                cmdSelect.CommandText = "SELECT COUNT(*) FROM Doctors WHERE Password = :pass1";
                                cmdSelect.Parameters.Clear();
                                cmdSelect.Parameters.Add("pass1", OracleDbType.Varchar2).Value = password;
                                int doctorPasswordCount = Convert.ToInt32(cmdSelect.ExecuteScalar());















                                if (existingCount == 0 && patientPasswordCount == 0 && NursePasswordCount == 0 && ReceptionistPasswordCount == 0 && doctorPasswordCount == 0 && Dmail == 0 && Pmail == 0 && Rmail == 0 && Nmail == 0)
                                {

                           
                                // The updated name doesn't exist in the NURSE table
                                OracleCommand cmdUpdate = con7.CreateCommand();
                                    cmdUpdate.CommandText = "UPDATE NURSE SET Name = :Name, Password = :Password, Email = :Email, Qualification = :Qualification, Gender = :Gender, Salary = :Salary WHERE id = :NURSE_id";
                                    cmdUpdate.Parameters.Add("Name", OracleDbType.Varchar2).Value = name;
                                    cmdUpdate.Parameters.Add("Password", OracleDbType.Varchar2).Value = password;
                                    cmdUpdate.Parameters.Add("Email", OracleDbType.Varchar2).Value = email;
                                    cmdUpdate.Parameters.Add("Qualification", OracleDbType.Varchar2).Value = qualification;
                                    cmdUpdate.Parameters.Add("Gender", OracleDbType.Varchar2).Value = gender;
                                    cmdUpdate.Parameters.Add("Salary", OracleDbType.Decimal).Value = salary;
                                    cmdUpdate.Parameters.Add("Nurse_id", OracleDbType.Int64).Value = NURSE_idd;

                                    int rowsAffected = cmdUpdate.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        con7.Close();
                                        updateGrid(); // Refresh the DataGridView
                                    }
                                    else
                                    {
                                        MessageBox.Show("No records updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        con7.Close();
                                        updateGrid(); // Refresh the DataGridView
                                    }
                                }
                                else
                                {
                                    if (patientPasswordCount > 0 || NursePasswordCount > 0 || ReceptionistPasswordCount > 0 || doctorPasswordCount > 0)
                                    {
                                        MessageBox.Show($"{patientPasswordCount}, {NursePasswordCount}, {ReceptionistPasswordCount}, {doctorPasswordCount}");
                                        MessageBox.Show("Password Exists. Please choose different .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        con7.Close();
                                        updateGrid();
                                        return;
                                    }
                                    else if (Dmail > 0 || Pmail > 0 || Rmail > 0 || Nmail > 0)
                                    {
                                        // Nurse with the same name already exists
                                        MessageBox.Show("Email Exists. Please choose different .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        con7.Close();
                                        updateGrid();
                                        return;
                                    }
                                   
                                    else  // The updated name already exists in the NURSE table
                                    {
                                        MessageBox.Show("The updated name already exists in the table. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        con7.Close();
                                        updateGrid();
                                        return;
                                    }
                                }


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                con7.Close();
                            }

                        }
                    }



                }
                //else
                //{
                //    MessageBox.Show("Selected row does not contain a valid Nurse ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }

            private void button4_Click(object sender, EventArgs e)
            {
                // Log out button
                // go to the login/sign up page
                Form1 form = new Form1();
                this.Hide();
                form.Show();
            }
        
        
    }
}