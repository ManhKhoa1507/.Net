using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Tcp : Form
    {
        public Tcp()
        {
            InitializeComponent();
        }

        private void client_Click(object sender, EventArgs e)
        {
            TCPClient tcpClient = new TCPClient();
            tcpClient.Show();
        }

        private void server_Click(object sender, EventArgs e)
        {
            TCPServer tcpServer = new TCPServer();
            tcpServer.Show();
        }
    }
}
