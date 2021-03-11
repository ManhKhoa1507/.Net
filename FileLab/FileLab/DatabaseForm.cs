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

namespace FileLab
{
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "Data Source = MANHKHOA; Initial Catalog = QLS; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                DataTable dataTable = new DataTable();
                SqlCommand command = new SqlCommand(DatabaseExport.Text, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                connection.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            //DatabaseExport.Text = "select * from SACH";
        }
    }
}
