using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Bai1
{
    public partial class MultipleServer : Form
    {

        List<Socket> clientList = new List<Socket>();
        Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public MultipleServer()
        {
            InitializeComponent();
        }

        private IPEndPoint GetIpEndPoint()
        {
            // Get the IP end point
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 8080;

            IPEndPoint ipEndPoint = new IPEndPoint(ip, port);
            return ipEndPoint;
        }

        private async void StartUnsafeThread()
        {
            // Start the unsafe thread
            Socket clientSocket;
            IPEndPoint ipEndPoint = GetIpEndPoint();
            listenerSocket.Bind(ipEndPoint);
            listenerSocket.Listen(-1);

            while (true)
            {
                clientSocket = await listenerSocket.AcceptAsync();
                clientList.Add(clientSocket);
                Thread TCPClient = new Thread(TCPThread);
                TCPClient.Start(clientSocket);
            }
        }

        private void TCPThread(object clientSocket)
        {
            Socket clientSocket1 = (Socket)clientSocket;
            int bytesReceived = 0;
            byte[] recv = new byte[1];


            richTextBox1.Text += "New connection from: " + clientSocket1.RemoteEndPoint + '\n';
            while ((clientSocket1.Poll(-1, SelectMode.SelectRead)) && (clientSocket1.Available != 0))
            {
                string text = "";
                do
                {
                    bytesReceived = clientSocket1.Receive(recv);
                    text += Encoding.UTF8.GetString(recv);

                } while (text[text.Length - 1] != '\n');
                richTextBox1.Text += text;

                sendBroadcast(text);
            }
        }

        private void sendBroadcast(string message)
        {
            // Send the message to all clients
            foreach (Socket socket in clientList)
            {
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                NetworkStream ns = new NetworkStream(socket);
                ns.Write(buffer, 0, buffer.Length);
            }
        }

        private void MultipleServer_FormClosing(object sender, EventArgs e)
        {
            // Close the connection when close the form
            listenerSocket.Close();
        }

        private void Listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();

            Listen.Enabled = false;
        }
    }
}
