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
    public partial class Total_Appointments_IN_Admin : Form
    {
        OracleConnection con13;

        public Total_Appointments_IN_Admin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Total_Appointments_IN_Admin_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE; USER ID=INSHALLL;PASSWORD=progr@mmer";
            con13 = new OracleConnection(conStr);
            updateGrid();
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            // Set the font style of column headers to bold
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            // Define custom colors




        }

        private void updateGrid()// for viewing the records
        {
            con13.Open();
            OracleCommand getEmps = con13.CreateCommand();
            getEmps.CommandText = "SELECT A_ID,PATIENT_ID, DOCTOR_NAME, S_TIME, E_TIME, STATUS, A_DATE, FEE, DISEASE FROM APPOINTMENT ORDER BY A_ID";
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
            con13.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Doctor Button, go to the doctor Page
            this.Hide();
            Doctor form1 = new Doctor();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Patient Button, go to the Patient Page
            this.Hide();
            PatientinAdmin form1 = new PatientinAdmin();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Appointment Button, go to the Admin Page
            this.Hide();
            Form2 form1 = new Form2();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Nurse Button, Go to the Nurse Page
            this.Hide();
            Nurse form1 = new Nurse();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Receptionist Button, Go to the Receptionist Page
            this.Hide();
            Receptionist form1 = new Receptionist();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
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
                object value = dataGridView1.Rows[e.RowIndex].Cells["A_Id"].Value;
                if (value != DBNull.Value && value != null)
                {
                    long A_idd = Convert.ToInt64(value);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        con13.Open();
                        OracleCommand getEmps = con13.CreateCommand();
                        getEmps.CommandText = "DELETE FROM APPOINTMENT WHERE A_ID = :A_idd";
                        getEmps.Parameters.Add("A_idd", OracleDbType.Int64).Value = A_idd; // Add parameter if Doctor_idd is of a different type
                        getEmps.CommandType = CommandType.Text;
                        int rowsAffected = getEmps.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con13.Close();
                            dataGridView1.Refresh();
                            updateGrid(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con13.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Selected row does not contain a valid APPOINTMENT ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            // go to login/signin page
            this.Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }
    }
}
