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

namespace ServerSocket
{
    public partial class TCPServer : Form
    {
        public TCPServer()
        {
            InitializeComponent();
        }

        private int ConvertStringToInt(string str)
        {
            return Convert.ToInt32(str);
        }

        delegate void ShowMessageCallBack(RichTextBox box, string message);

        private void ShowMessage(RichTextBox box, string message)
        {
            // Show message to richTextBox
           if(box.InvokeRequired)
            {
                ShowMessageCallBack d = new ShowMessageCallBack(ShowMessage);
                this.Invoke(d, new object[] { box, message });
            }

            else
            {
                box.Text += message + "\n";

            }
        }

        private string GetMessage(UdpClient udpClient, IPEndPoint ipEndPoint)
        {
            // Get the message from client
            Byte[] receiveBytes = udpClient.Receive(ref ipEndPoint);

            string data = Encoding.UTF8.GetString(receiveBytes);
            string message = ipEndPoint.Address.ToString() + ": "
                + ipEndPoint.Port.ToString() + ": " + data.ToString();

            return message;
        }

        private void ServerThread()
        {
            int port = ConvertStringToInt(textBox1.Text);
            UdpClient udpClient = new UdpClient(port);

            while(true)
            {
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, 0);

                string message = GetMessage(udpClient,ipEndPoint);
                ShowMessage(richTextBox1, message); 
            }      
        }

        private void Listen_Click(object sender, EventArgs e)
        {
            try
            {
                // Use Thread to start server
                Thread t = new Thread(new ThreadStart(ServerThread));
                t.Start();
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
