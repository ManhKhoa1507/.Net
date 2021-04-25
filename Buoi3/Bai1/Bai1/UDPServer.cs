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
    public partial class UDPServer : Form
    {
        public UDPServer()
        {
            InitializeComponent();
        }

        private int ConvertStringToInt(string str)
        {
            // Convert string to int 32
            return Convert.ToInt32(str);
        }

        private string GetMessage(UdpClient udpClient, IPEndPoint ipEndPoint)
        {
            Byte[] receiveBytes = udpClient.Receive(ref ipEndPoint);

            string data = Encoding.UTF8.GetString(receiveBytes);
            string message = ipEndPoint.Address.ToString() + ":"
                + ipEndPoint.Port.ToString() + " " + data.ToString() + "\n";
            return message;
        }

        delegate void ShowMessageCallBack(RichTextBox box, string message);

        private void ShowMessage(RichTextBox box, string message)
        {
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

        public void ServerThread()
        {
            //int port = ConvertStringToInt(PortBox.Text);

            UdpClient udpClient = new UdpClient(8080);
            while (true)
            {
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, 0);

                string message = GetMessage(udpClient, ipEndPoint);
                ShowMessage(MessageBox, message);        
            }
        }

        private void Listen_Click(object sender, EventArgs e)
        {
            try
            {
                Thread t = new Thread(new ThreadStart(ServerThread));
                t.Start();
            }
            catch(Exception)
            {
                
            }
        }
    }
}
