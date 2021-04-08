using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSocket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UDPClient_Click(object sender, EventArgs e)
        {

        }

        private void TCPClient_Click(object sender, EventArgs e)
        {
            TCPClientForm tcpClient = new TCPClientForm();
            tcpClient.ShowDialog();
            this.Hide();
        }
    }
}
