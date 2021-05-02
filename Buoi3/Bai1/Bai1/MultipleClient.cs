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
    public partial class MultipleClient : Form
    {
        NetworkStream stream;
        TcpClient tcpClient = new TcpClient();

        public MultipleClient()
        {
            InitializeComponent();
        }

        private void CloseConnection(NetworkStream stream, TcpClient client)
        {
            // Close the connection
            stream.Close();
            client.Close();
        }

        private void StartUnsafeThread(object obj)
        {
            // Start the unsafe thread

            TcpClient tcpClient = (TcpClient)obj;
            NetworkStream ns = tcpClient.GetStream();
            byte[] BytesReceived = new byte[1];

            // Display all the message from all clients
            while (tcpClient.Connected)
            {
                string text = "";
                do
                {

                    ns.Read(BytesReceived, 0, BytesReceived.Length);
                    text += Encoding.UTF8.GetString(BytesReceived);

                } while (text[text.Length - 1] != '\n');
                richTextBox1.Text += text;
            }

            // Close connection 
            CloseConnection(ns, tcpClient);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            // Send message
            Byte[] data = Encoding.UTF8.GetBytes(textBox1.Text + " : " + textBox2.Text + '\n');
            stream.Write(data, 0, data.Length);

            // Clear the text box
            textBox2.Clear();
        }

        private async void MultipleClient_Load(object sender, EventArgs e)
        {
            // Connect to the 127.0.0.1:8080 when the form is loading
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 8080;
            await tcpClient.ConnectAsync(ip, port);

            stream = tcpClient.GetStream();

            CheckForIllegalCrossThreadCalls = false;

            Thread serverThread = new Thread(StartUnsafeThread);
            serverThread.Start(tcpClient);
        }

        private void TCPServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
