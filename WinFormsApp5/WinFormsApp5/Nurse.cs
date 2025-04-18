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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No records found to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
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

                object value2 = dataGridView1.Rows[e.RowIndex].Cells["NURSE_id"].Value;
                if (value2 != DBNull.Value && value2 != null)
                {
                    long NURSE_idd = Convert.ToInt64(value2);

                    // Get values for update from DataGridView
                    string name = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Name"].Value);
                    string password = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Password"].Value);
                    string email = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Email"].Value);
                    string qualification = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Qualification"].Value);
                    string gender = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value);
                    float salary = Convert.ToSingle(dataGridView1.Rows[e.RowIndex].Cells["Salary"].Value);

                    DialogResult result = MessageBox.Show("Are you sure you want to update this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
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

                            // Third check
                            cmdSelect.CommandText = "SELECT COUNT(*) FROM NURSE WHERE Password = :pass1";
                            cmdSelect.Parameters.Clear();
                            cmdSelect.Parameters.Add("pass1", OracleDbType.Varchar2).Value = password;
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






                            if (existingCount == 0 && patientPasswordCount == 0 && NursePasswordCount == 0 && ReceptionistPasswordCount == 0 && doctorPasswordCount == 0)
                            {

                                // The updated name doesn't exist in the NURSE table
                                OracleCommand cmdUpdate = con7.CreateCommand();
                                cmdUpdate.CommandText = "UPDATE NURSE SET Name = :Name, Password = :Password, Email = :Email, Qualification = :Qualification, Gender = :Gender, Salary = :Salary WHERE NURSE_id = :NURSE_id";
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
                                  if (patientPasswordCount == 0 || NursePasswordCount == 0 || ReceptionistPasswordCount == 0 || doctorPasswordCount == 0)
                                {
                                    // Nurse with the same name already exists
                                    MessageBox.Show("Password Exists. Please choose different .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else  // The updated name already exists in the NURSE table
                                MessageBox.Show("The updated name already exists in the table. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Selected row does not contain a valid Nurse ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
