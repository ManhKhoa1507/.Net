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
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            UDPClient client = new UDPClient();
            client.Show();
        }

        private void Server_Click(object sender, EventArgs e)
        {
            UDPServer server = new UDPServer();
            server.Show();
        }
    }
}
