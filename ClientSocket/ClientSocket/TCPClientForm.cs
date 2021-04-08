using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ClientSocket
{
    public partial class TCPClientForm : Form
    {
        public TCPClientForm()
        {
            InitializeComponent();
        }

        private int ConvertStringToInt(string str)
        {
            // Convert string to int32
            return Convert.ToInt32(str);
        }
        
        private IPEndPoint GetIPEnd(string ipBox, string portText)
        {
            // Get the IP endpoint
            IPAddress ipAddress = IPAddress.Parse(ipBox);
            int port = ConvertStringToInt(portText);

            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, port);
            return ipEndPoint;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
         
            // Get the IP endpoint
            IPEndPoint ipEndPoint = GetIPEnd(textBox1.Text, textBox3.Text);

            // Convert the message to bytes
            Byte[] sendBytes = Encoding.UTF8.GetBytes(textBox2.Text);

            // Send the message to the given IP and Port number
            udpClient.Send(sendBytes, sendBytes.Length, ipEndPoint);
            textBox2.Text = "";
        }
    }
}
