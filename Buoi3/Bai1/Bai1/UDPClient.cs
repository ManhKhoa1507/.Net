using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace Bai1
{
    public partial class UDPClient : Form
    {
        public UDPClient()
        {
            InitializeComponent();
        }

        private int StringToInt(string str)
        {
            return Convert.ToInt32(str);
        }

        private IPEndPoint GetIPEnd(string ipBox, string portBox)
        {
            // Get the IP endpoint 
            IPAddress ipAddress = IPAddress.Parse(ipBox);
            int port = StringToInt(portBox);

            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, port);
            return ipEndPoint;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            // Click to send the message 
            UdpClient udpClient = new UdpClient();

            // Get the IP endpoint 
            IPEndPoint ipEndPoint = GetIPEnd(IPText.Text, PortText.Text);

            // Get the messag box 
            Byte[] sendBytes = Encoding.UTF8.GetBytes(MessageText.Text);

            // Send the message 
            udpClient.Send(sendBytes, sendBytes.Length, ipEndPoint);

            // Clear the message box
            MessageText.Text = "";
        }
    }
}
