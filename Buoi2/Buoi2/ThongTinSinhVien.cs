using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Microsoft.SqlServer.Server;

namespace Buoi2
{
    public partial class ThongTinSinhVien : Form
    {
        Char[] buffer;
        public static OpenFileDialog ofd = new OpenFileDialog();
        private System.Data.DataTable dataTable = new System.Data.DataTable();
        const string errorMessage = "Vui lòng nhập lại";
        public ThongTinSinhVien()
        {
            InitializeComponent();
        }

        private void Write_Click(object sender, EventArgs e)
        {
            NhapSinhVien nhapSinhVien = new NhapSinhVien();
            nhapSinhVien.ShowDialog();
        }

        private double StringToDouble(string str)
        {
            // Convert string to Int32
            return Convert.ToDouble(str);
        }

        private string MakeInsertValueQuery(string line)
        {
            // Make insert query to DB from studentCode ,studentName, phone, mathPoint, lecturePoint
            // Return query string
            List<string> valueList = line.Split(';').ToList();
            
            double mathPoint = StringToDouble(valueList[3]);
            double lecturePoint = StringToDouble(valueList[4]);

            double temp = (mathPoint + lecturePoint) / 2;
            double AverageGrade = Math.Round(temp, 2); 

            string query = "INSERT INTO SINHVIEN(Mssv, Ten, SoDienThoai, DiemToan, DiemVan, DiemTrungBinh) " +
                "VALUES ('" + valueList[0] +"' ,'"+ valueList[1] + "' ,'" + valueList[2] + "' ," 
                + valueList[3] + " ," + valueList[4] + " ," + AverageGrade + ");";

            return query;
        }

        private static string CreateConnectionString()
        {
            // Create connection string 
            // Connect to DB
            string dataSource = "Data Source = MANHKHOA; ";
            string initicalCatalog = "Initial Catalog = QLSV; ";
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

            return connectionString;
        }

        private void DisplayToDataGrid()
        {
            // Clear and Display data to dataGrid
            // Make export DB query to list all values in table SINHVIEN 
            string exportDBQuery = "SELECT * FROM SINHVIEN";
            ExecuteExportQuery(exportDBQuery);

            // Display to dataGrid
            dataGridView1.DataSource = dataTable;
        }

        // Make connection string and Connect to DB
        static string connectionString = CreateConnectionString();
        SqlConnection connection = new SqlConnection(connectionString);

        private void ExecuteExportQuery(string query)
        {
            // Execute the query to export the DB to datagrid  
            connection.Open();

            // Run the SQL command 
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            // Fill the dataGrid by dataTable
            dataAdapter.Fill(dataTable);

            connection.Close();
        }

        private void ExecuteQuery(string query)
        {
            // Excecuting the query 
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            command.ExecuteNonQuery();
            
            connection.Close();
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            try
            {
                // Read the file
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    int srLength = (int)sr.BaseStream.Length;
                    buffer = new Char[srLength];

                    await sr.ReadAsync(buffer, 0, srLength);
                }
                string content = new string(buffer);

                // Split each lines in file
                List<string> linesList = content.Split('\n').ToList();
                
                // Execute the query
                foreach (string line in linesList)
                {
                    string query = MakeInsertValueQuery(line);
                    ExecuteQuery(query);
                }

            }
            catch (Exception)
            {
                MessageBox.Show(errorMessage, "Error");
            }
        }

        private void GetInfo_Click(object sender, EventArgs e)
        {
            try
            {
                // Display to DataGrid
                DisplayToDataGrid();
            }
            catch(Exception)
            {
                MessageBox.Show(errorMessage, "Error");
            }
        }

        private void GetLocation_Click(object sender, EventArgs e)
        {
            // Get location of saved file
            ofd.ShowDialog();
        }
    }
}