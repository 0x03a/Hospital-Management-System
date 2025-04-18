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
    public partial class PatientinAdmin : Form
    {
        OracleConnection con5;
        public PatientinAdmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open Doctors Form
            // it should open add Doctors page
            Doctor form1 = new Doctor();
            this.Hide();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }

        private void PatientinAdmin_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=INSHALLL;PASSWORD=progr@mmer";
            con5 = new OracleConnection(conStr);
            updateGrid();
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            // Set the font style of column headers to bold
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // get back to Admin Page(form2)
            Form2 form1 = new Form2();
            this.Hide();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
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

        private void button8_Click(object sender, EventArgs e)
        {
            // Nurse button , go to the nurse page
            // Go to the  Nurse page
            this.Hide();
            Nurse form = new Nurse();
            form.Closed += (s, args) => form.Close();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Receptionist button
            this.Hide();
            Receptionist form = new Receptionist();
            form.Closed += (s, args) => form.Close();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Go Back to admin Page
            Form1 form1 = new Form1();
            this.Hide();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }


        private void updateGrid()
        {
            con5.Open();
            OracleCommand getEmps = con5.CreateCommand();
            getEmps.CommandText = "SELECT * FROM PATIENT";
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


            con5.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;
                if (value != DBNull.Value && value != null)
                {
                    long Patient_idd = Convert.ToInt64(value);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        con5.Open();
                        OracleCommand getEmps = con5.CreateCommand();
                        getEmps.CommandText = "DELETE FROM PATIENT WHERE id = :Patient_idd";
                        getEmps.Parameters.Add("Patient_idd", OracleDbType.Int64).Value = Patient_idd; // Add parameter if Patient_idd is of a different type
                        getEmps.CommandType = CommandType.Text;
                        int rowsAffected = getEmps.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con5.Close();
                            updateGrid(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con5.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Selected row does not contain a valid Patient ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
