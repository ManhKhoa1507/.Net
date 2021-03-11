using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using Microsoft.Office.Interop.Excel;

namespace FileLab
{
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
        }

        // Execute the SQL command
        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                string dataSource = "Data Source = MANHKHOA; ";
                string initicalCatalog = "Initial Catalog = QLS; ";
                string integratedSecurity = "Integrated Security = True; ";
                string connectTimeout = "Connect Timeout = 30; ";
                string encrypt = "Encrypt = False; ";
                string trustServerCertificate = "TrustServerCertificate = False; ";
                string appicationIntent = "ApplicationIntent = ReadWrite; ";
                string multiSubnetFailover = "MultiSubnetFailover = False";

                // Create a connection string
                string connectionString;

                connectionString = dataSource + initicalCatalog + integratedSecurity +
                        connectTimeout + encrypt + trustServerCertificate + appicationIntent + multiSubnetFailover;

                // connect to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create dataTable 
                    System.Data.DataTable dataTable = new System.Data.DataTable();

                    // Run the SQL command in the DatabaseExport textBox
                    SqlCommand command = new SqlCommand(DatabaseExport.Text, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    // Fill the dataGrid by dataTable
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                    // Close the connection 
                    connection.Close();
                }
            }

            // If errror 
            catch (Exception exception)
            {
                //  Open the messagebox and show the error
                MessageBox.Show(exception.ToString(), "Error");
                return;
            }
        }

        // Export to excel
        private void btnExportData_Click(object sender, EventArgs e)
        {
            try
            {

                // Open the Microsoft Excel 
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                var workbook = excelApp.Workbooks.Add(Type.Missing);

                // Export to Excel 
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {

                    excelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Save the file 
                SaveFileDialog sfd = new SaveFileDialog();

                // Set Default Ext, FileName, Extension and Filter
                sfd.DefaultExt = "xlsc";
                sfd.FileName = "ExportDatabase";
                sfd.AddExtension = true;
                sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";

                sfd.ShowDialog();

                // Save excel file  
                excelApp.Application.ActiveWorkbook.SaveCopyAs(sfd.FileName);
                excelApp.Application.ActiveWorkbook.Saved = true;

                // Close Excel
                excelApp.Application.Quit();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Error");
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
