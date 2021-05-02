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
using System.Threading;


namespace Bai1
{
    public partial class TCPClient : Form
    {
        public TCPClient()
        {
            InitializeComponent();
        }

        private void TCPClient_Load(object sender, EventArgs e)
        {
            
        }

        private IPEndPoint GetIPEndPoint()
        {
            // Get the Ip Endpoint 
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 8080);
            return ipEndPoint;
        }

        private void SendMessage(NetworkStream networkStream,string str)
        {
            // Send the message to the server
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(str + "\n");
            networkStream.Write(data, 0, data.Length);
        }

        private void send_Click(object sender, EventArgs e)
        {
            // Create tcpClient, ipAddress and ipEndpoint
            TcpClient tcpClient = new TcpClient();
            IPEndPoint ipEndPoint = GetIPEndPoint();

            // Connect to 127.0.0.1:8080
            tcpClient.Connect(ipEndPoint);

            // Create a stream to read and write
            NetworkStream networkStream = tcpClient.GetStream();

            // Use write method to send the message "Hello Server" to server 
            SendMessage(networkStream, "Hello Server");

            // Close the connection
            networkStream.Close();
            tcpClient.Close();
        }
    }
}
