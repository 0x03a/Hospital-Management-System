using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using Chloe;

namespace WinFormsApp5
{
    public partial class Form2 : Form
    {
        OracleConnection con1;
        private int patientCount = 0;


        public Form2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            // Assuming con1 is your OracleConnection object


        }





        private void Form2_Load(object sender, EventArgs e)
        {

            // updating the Patient as New Patient is Added
            string con1Str = @"DATA SOURCE=localhost:1521/XE;USER ID=INSHALLL;PASSWORD=progr@mmer";
            con1 = new OracleConnection(con1Str);

            con1.Open();
            OracleCommand command = con1.CreateCommand();
            command.CommandText = "SELECT COUNT(*) FROM PATIENT";
            command.CommandType = CommandType.Text;

            // Execute the command and get the result
            int totalCount = Convert.ToInt32(command.ExecuteScalar());

            // Update the label text with the count
            label9.Text = totalCount.ToString();
            label9.Refresh();
            // Close the connection
            con1.Close();


            con1.Open();
            OracleCommand command1 = con1.CreateCommand();
            command1.CommandText = "SELECT COUNT(*) FROM DOCTORS";
            command1.CommandType = CommandType.Text;

            // Execute the command and get the result
            int totalCount1 = Convert.ToInt32(command1.ExecuteScalar());

            // Update the label text with the count
            label13.Text = totalCount1.ToString();
            label13.Refresh();
            // Close the connection
            con1.Close();




            con1.Open();
            OracleCommand command2 = con1.CreateCommand();
            command2.CommandText = "SELECT COUNT(*) FROM NURSE";
            command2.CommandType = CommandType.Text;

            // Execute the command and get the result
            int totalCount2 = Convert.ToInt32(command2.ExecuteScalar());

            // Update the label text with the count
            label22.Text = totalCount2.ToString();
            label22.Refresh();
            // Close the connection
            con1.Close();



            con1.Open();
            OracleCommand command3 = con1.CreateCommand();
            command3.CommandText = "SELECT COUNT(*) FROM RECEPTIONIST";
            command3.CommandType = CommandType.Text;

            // Execute the command and get the result
            int totalCount3 = Convert.ToInt32(command3.ExecuteScalar());

            // Update the label text with the count
            label25.Text = totalCount3.ToString();
            label25.Refresh();
            // Close the connection
            con1.Close();



            con1.Open();
            OracleCommand command4 = con1.CreateCommand();
            command4.CommandText = "SELECT COUNT(*) FROM APPOINTMENT";
            command4.CommandType = CommandType.Text;

            // Execute the command and get the result
            int totalCount4 = Convert.ToInt32(command4.ExecuteScalar());

            // Update the label text with the count
            label18.Text = totalCount4.ToString();
            label18.Refresh();
            // Close the connection
            con1.Close();



        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            // hide form2(Admin or dashboard)
            this.Hide();
            // Show Home page (form1)
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {



        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor form = new Doctor();
            form.Closed += (s, args) => form.Close();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show Patient Viewd By Admin
            this.Hide();
            PatientinAdmin form = new PatientinAdmin();
            form.Closed += (s, args) => form.Close();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            // Nurse button
            // Showing the Nurse page
            this.Hide();
            Nurse form = new Nurse();

            form.Closed += (s, args) => form.Close();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Receptionist button 
            // Go to the recepionist page
            this.Hide();
            Receptionist form = new Receptionist();
            form.Closed += (s, args) => form.Close();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Go to the Appointment Page in Admin

            this.Hide();
            Total_Appointments_IN_Admin form1 = new Total_Appointments_IN_Admin();
            form1.Closed += (s, args) => form1.Close();
            form1.Show();
        }





        private void button6_Click(object sender, EventArgs e)
        {

            // Generating report
            con1.Open();
            OracleCommand total = con1.CreateCommand();
            total.CommandText = "SELECT SUM(FEE) AS TOTAL_REVENUE FROM APPOINTMENT";
            total.CommandType = CommandType.Text;
            // Execute the command and get the result
            int totalCount = Convert.ToInt32(total.ExecuteScalar());
            con1.Close();

            con1.Open();

            OracleCommand report = con1.CreateCommand();
            report.CommandText = "SELECT P.NAME,A.DOCTOR_NAME,A.A_DATE AS APPOINTMENT_DATE, A.FEE FROM APPOINTMENT A INNER JOIN PATIENT P ON P.ID = A.PATIENT_ID";
            report.CommandType = CommandType.Text;

            // Execute the query and load data into a DataTable
            DataTable dataTable = new DataTable();
            using (OracleDataReader reader = report.ExecuteReader())
            {
                dataTable.Load(reader);
            }

            if (dataTable.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (.pdf)|.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data to disk: " + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            // Create a Paragraph for the heading
                            Paragraph heading = new Paragraph("REVENUE", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16f));
                            heading.Alignment = Element.ALIGN_CENTER;

                            // Create a Paragraph for space after heading
                            Paragraph space = new Paragraph("\n");

                            PdfPTable pTable = new PdfPTable(dataTable.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            // Add column headers to the PDF table
                            foreach (DataColumn col in dataTable.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.ColumnName));
                                pTable.AddCell(pCell);
                            }

                            // Add data rows to the PDF table
                            foreach (DataRow row in dataTable.Rows)
                            {
                                foreach (var item in row.ItemArray)
                                {
                                    pTable.AddCell(item.ToString());
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();

                                // Add the heading to the document
                                document.Add(heading);

                                // Add space after the heading
                                document.Add(space);

                                // Add the table to the document
                                document.Add(pTable);

                                // Create a Paragraph for total revenue
                                Paragraph totalRevenue = new Paragraph("Total Revenue: " + totalCount.ToString());
                                totalRevenue.Alignment = Element.ALIGN_RIGHT;
                                document.Add(totalRevenue);

                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Exported Successfully", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting data: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Records Found", "Info");
            }
            con1.Close();


        }

    }
}
