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
    public partial class Receptionist : Form
    {
        OracleConnection con8;
        public Receptionist()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void Receptionist_Load(object sender, EventArgs e)
        {

            // Receptionist connection
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID= INSHALLL; PASSWORD=progr@mmer; ";
            con8 = new OracleConnection(conStr);
            updateGrid();
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            // Set the font style of column headers to bold
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Doctors Button
            Doctor form = new Doctor();
            this.Hide();
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Patient button
            PatientinAdmin form = new PatientinAdmin();
            this.Hide();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // total Appointment button
            // Go to the Appointpage page
            this.Hide();
            Total_Appointments_IN_Admin form1 = new Total_Appointments_IN_Admin();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Nurse Button
            // Go to Nurse page
            Nurse form = new Nurse();
            this.Hide();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Receptionist button
            // Back to admin Page
            Form2 form1 = new Form2();
            this.Hide();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // add_receptionist button
            this.Hide();
            Receptionist_add form = new Receptionist_add();
            form.FormClosed += (s, args) => form.Close();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // update_receptionist
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Logout Button 
            // Back to admin Page
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }


        private void updateGrid()// for viewing the records
        {
            con8.Open();
            OracleCommand getEmps = con8.CreateCommand();
            getEmps.CommandText = "SELECT * FROM RECEPTIONIST";
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

            con8.Close();

            con8.Open();

            OracleCommand getEmps2 = con8.CreateCommand();
            getEmps2.CommandText = "SELECT * FROM RECEPTIONIST";
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

            con8.Close();
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
                    long RECEPTIONIST_idd = Convert.ToInt64(value);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        con8.Open();
                        OracleCommand getEmps = con8.CreateCommand();
                        getEmps.CommandText = "DELETE FROM RECEPTIONIST WHERE id = :RECEPTIONIST_idd";
                        getEmps.Parameters.Add("RECEPTIONIST_idd", OracleDbType.Int64).Value = RECEPTIONIST_idd; // Add parameter if RECEPTIONIST_idd is of a different type
                        getEmps.CommandType = CommandType.Text;
                        int rowsAffected = getEmps.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con8.Close();
                            updateGrid(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con8.Close();
                    }
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Update"].Index && e.RowIndex >= 0)
            {

                object value2 = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;
                if (value2 != DBNull.Value && value2 != null)
                {
                    long RECEPTIONIST_idd = Convert.ToInt64(value2);

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
                            con8.Open();
                            OracleCommand cmdSelect = con8.CreateCommand();
                            // First check
                            cmdSelect.CommandText = "SELECT COUNT(*) FROM RECEPTIONIST WHERE Name = :UpdatedName AND id != :RECEPTIONIST_id";
                            cmdSelect.Parameters.Clear();
                            cmdSelect.Parameters.Add("UpdatedName", OracleDbType.Varchar2).Value = name;
                            cmdSelect.Parameters.Add("RECEPTIONIST_id", OracleDbType.Int64).Value = RECEPTIONIST_idd;
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
                                
                                // The updated name doesn't exist in the RECEPTIONIST table
                                OracleCommand cmdUpdate = con8.CreateCommand();
                                cmdUpdate.CommandText = "UPDATE RECEPTIONIST SET Name = :Name, Password = :Password, Email = :Email, Qualification = :Qualification, Gender = :Gender, Salary = :Salary WHERE id = :RECEPTIONIST_id";
                                cmdUpdate.Parameters.Add("Name", OracleDbType.Varchar2).Value = name;
                                cmdUpdate.Parameters.Add("Password", OracleDbType.Varchar2).Value = password;
                                cmdUpdate.Parameters.Add("Email", OracleDbType.Varchar2).Value = email;
                                cmdUpdate.Parameters.Add("Qualification", OracleDbType.Varchar2).Value = qualification;
                                cmdUpdate.Parameters.Add("Gender", OracleDbType.Varchar2).Value = gender;
                                cmdUpdate.Parameters.Add("Salary", OracleDbType.Decimal).Value = salary;
                                cmdUpdate.Parameters.Add("RECEPTIONIST_id", OracleDbType.Int64).Value = RECEPTIONIST_idd;

                                int rowsAffected = cmdUpdate.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    con8.Close();
                                    updateGrid(); // Refresh the DataGridView
                                }
                                else
                                {
                                    MessageBox.Show("No records updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    con8.Close();
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
                                else  // The updated name already exists in the RECEPTIONIST table
                                MessageBox.Show("The updated name already exists in the table. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            con8.Close();
                        }


                    }


                }



            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
