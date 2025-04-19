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
            Doctor_Name = Doc_Name;
            Doctor_Password = Doc_pass;
        }

        private void Total_App_IN_DOCTORS_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE; USER ID=INSHALLL;PASSWORD=progr@mmer";
            con14 = new OracleConnection(conStr);

            updateGrid();
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
        }

        private void updateGrid()
        {
            con14.Open();
            OracleCommand getEmps = con14.CreateCommand();
            getEmps.CommandText = "SELECT A_ID, PATIENT_ID, DOCTOR_NAME, S_TIME, E_TIME, STATUS, A_DATE, FEE, DISEASE FROM APPOINTMENT ORDER BY A_DATE";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);

            dataGridView1.DataSource = empDT;
            Doctor.Text = Doctor_Name;

            // Remove existing STATUS column if it exists
            if (dataGridView1.Columns.Contains("STATUS"))
            {
                dataGridView1.Columns.Remove("STATUS");
            }

            // Add ComboBox column for STATUS
            DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn();
            statusColumn.HeaderText = "STATUS";
            statusColumn.Name = "STATUS";
            statusColumn.DataPropertyName = "STATUS";
            statusColumn.Items.AddRange("PENDING", "APPROVED", "CANCELLED", "COMPLETED");
            dataGridView1.Columns.Add(statusColumn);

            // Add Update button column
            DataGridViewButtonColumn updateButton = new DataGridViewButtonColumn();
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.HeaderText = "Action";
            updateButton.Name = "Update";
            updateButton.UseColumnTextForButtonValue = true;
            updateButton.Text = "Update";
            updateButton.Width = 100;

            if (!dataGridView1.Columns.Contains("Update"))
            {
                dataGridView1.Columns.Add(updateButton);
            }

            // Make all columns read-only except STATUS
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name != "STATUS")
                {
                    column.ReadOnly = true;
                }
            }

            con14.Close();

            // Apply color coding
            ApplyStatusColorCoding();
        }

        private void ApplyStatusColorCoding()
        {
            Color lightRed = Color.FromArgb(220, 120, 120);
            Color lightGreen = Color.FromArgb(144, 238, 144);
            Color lightYellow = Color.FromArgb(255, 255, 150);
            Color lightGray = Color.FromArgb(200, 200, 200);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["STATUS"].Value != null)
                {
                    DataGridViewCell cell = row.Cells["STATUS"];
                    string status = cell.Value.ToString();

                    switch (status)
                    {
                        case "PENDING":
                            cell.Style.BackColor = lightRed;
                            cell.Style.ForeColor = Color.Black;
                            break;
                        case "APPROVED":
                            cell.Style.BackColor = lightGreen;
                            cell.Style.ForeColor = Color.Black;
                            break;
                        case "CANCELLED":
                            cell.Style.BackColor = lightGray;
                            cell.Style.ForeColor = Color.Black;
                            break;
                        case "COMPLETED":
                            cell.Style.BackColor = lightYellow;
                            cell.Style.ForeColor = Color.Black;
                            break;
                    }
                    cell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.Rows.Count == 0)
            {
                return;
            }

            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
            {
                long A_id = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["A_ID"].Value);
                string newStatus = dataGridView1.Rows[e.RowIndex].Cells["STATUS"].Value.ToString();
                string currentStatus = GetCurrentStatusFromDatabase(A_id);

                // Validate status transition
                if (currentStatus == "COMPLETED" || currentStatus == "CANCELLED")
                {
                    MessageBox.Show($"Cannot change status from {currentStatus}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show($"Change status from {currentStatus} to {newStatus}?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con14.Open();
                        OracleCommand cmd = con14.CreateCommand();
                        cmd.CommandText = "UPDATE APPOINTMENT SET STATUS = :status WHERE A_ID = :A_id";
                        cmd.Parameters.Add("status", OracleDbType.Varchar2).Value = newStatus;
                        cmd.Parameters.Add("A_id", OracleDbType.Int64).Value = A_id;

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            con14.Close();
                            updateGrid();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("No records updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con14.Close();
                            updateGrid();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con14.Close();
                        updateGrid();
                        return;
                    }
                    finally
                    {
                        con14.Close();
                    }
                }
            }
        }

        private string GetCurrentStatusFromDatabase(long A_id)
        {
            string status = "";
            try
            {
                con14.Open();
                OracleCommand cmd = con14.CreateCommand();
                cmd.CommandText = "SELECT STATUS FROM APPOINTMENT WHERE A_ID = :A_id";
                cmd.Parameters.Add("A_id", OracleDbType.Int64).Value = A_id;
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    status = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving current status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con14.Close() ;
                updateGrid();
               
            }
            finally
            {
                con14.Close();
            }
            return status;
        }

        private void Doctor_Click(object sender, EventArgs e)
        {
            // label doctor_name
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }

        private void Tappbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor_view form1 = new Doctor_view(Doctor_Name, Doctor_Password);
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }
    }
}