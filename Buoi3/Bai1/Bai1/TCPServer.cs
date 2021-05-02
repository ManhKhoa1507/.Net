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
    public partial class TCPServer : Form
    {
        public TCPServer()
        {
            InitializeComponent();
        }
        void StartUnsafeThread()
        {
            int byteReceived = 0;

            // Create byte array to receive the data
            byte[] recv = new byte[1];

            // Create socket for sender
            Socket clientSocket;

            // Create socket for receiver with the Address Family, Type of Socket is Stream and Protocol is Tcp
            Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Create ipEndpoint for server 
            IPEndPoint ipEndPointServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            // Start listen
            listenSocket.Bind(ipEndPointServer);
            listenSocket.Listen(-1);

            // Accept and connect the client  
            clientSocket = listenSocket.Accept();
            listView1.Items.Add(new ListViewItem("New client connect"));

            // Start listening 
            while (clientSocket.Connected)
            {
                string text = "";

                do
                {
                    byteReceived = clientSocket.Receive(recv);
                    text += Encoding.UTF8.GetString(recv);
                } while (text[text.Length - 1] != '\n');

                listView1.Items.Add(new ListViewItem(text));
            }

            // Close the connection 
            listenSocket.Close();
        }

        private void listenButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
                serverThread.Start();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
