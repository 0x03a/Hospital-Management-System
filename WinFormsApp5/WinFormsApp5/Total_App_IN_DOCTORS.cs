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
    public partial class Total_App_IN_DOCTORS : Form
    {

        OracleConnection con14;
        private string Doctor_Name = "";
        private string Doctor_Password = "";
        public Total_App_IN_DOCTORS()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public Total_App_IN_DOCTORS(string Doc_Name, string Doc_pass)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Doctor_Name = Doc_Name; Doctor_Password = Doc_pass;

        }

        private void Total_App_IN_DOCTORS_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE; USER ID=INSHALLL;PASSWORD=progr@mmer";
            con14 = new OracleConnection(conStr);

            updateGrid();
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            // Set the font style of column headers to bold
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);


           



        }

        private void updateGrid()// for viewing the records
        {
            con14.Open();
            OracleCommand getEmps = con14.CreateCommand();
            getEmps.CommandText = "SELECT A_ID,PATIENT_ID, DOCTOR_NAME, S_TIME, E_TIME, STATUS, A_DATE, FEE, DISEASE FROM APPOINTMENT ORDER BY A_DATE";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);

            dataGridView1.DataSource = empDT;
            Doctor.Text = Doctor_Name;

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

            con14.Close();
            Color lightRed = Color.FromArgb(220, 120, 120); // Light Red
            Color lightGreen = Color.FromArgb(144, 238, 144); // Light Green
            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Get the cell in the 6th column
                DataGridViewCell cell = row.Cells[5]; // 6th column (index 5)

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



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No records found to update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }




            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index && e.RowIndex >= 0)
            {

                // Check if the cell value for A_id is not null
                object value = dataGridView1.Rows[e.RowIndex].Cells["A_id"].Value;
                if (value != DBNull.Value && value != null)
                {
                    long A_idd = Convert.ToInt64(value);

                    // Get the new status value from the DataGridView
                    string status = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["STATUS"].Value);

                    // Ensure the status value is not null before proceeding with the update
                    if (!string.IsNullOrEmpty(status))
                    {
                        // Prompt the user for confirmation
                        DialogResult result = MessageBox.Show("Are you sure you want to update this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                con14.Open();
                                OracleCommand cmd = con14.CreateCommand();
                                cmd.CommandText = "UPDATE APPOINTMENT SET STATUS=:statuss WHERE A_id = :A_idd";
                                cmd.Parameters.Add("statuss", OracleDbType.Varchar2).Value = status;
                                cmd.Parameters.Add("A_idd", OracleDbType.Int64).Value = A_idd;

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    con14.Close();
                                    dataGridView1.Refresh();
                                    updateGrid(); // Refresh the DataGridView

                                    
                                }
                                else
                                {
                                    MessageBox.Show("No records updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    con14.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                con14.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Status value cannot be null or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }




            }

        }


   


        private void Doctor_Click(object sender, EventArgs e)
        {
            // label doctor_name
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            // go to the login/sign in page
            this.Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }

        private void Tappbtn_Click(object sender, EventArgs e)
        {
            // go to the Doctor View again
            this.Hide();
            Doctor_view form1 = new Doctor_view(Doctor_Name, Doctor_Password);
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }
    }
}
