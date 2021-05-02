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
    public partial class MultiTCP : Form
    {
        public MultiTCP()
        {
            InitializeComponent();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            MultipleClient client = new MultipleClient();
            client.Show();
        }

        private void Server_Click(object sender, EventArgs e)
        {
            MultipleServer server = new MultipleServer();
            server.Show();
        }
    }
}
