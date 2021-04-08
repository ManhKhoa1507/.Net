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

namespace DNS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GetDNSHostName()
        {
            string hostName = Dns.GetHostName();
            return hostName;
        }

        private void ShowIPAddress_Click(object sender, EventArgs e)
        {
            // Get all the IP of the hostname
            IPAddress[] IPList = Dns.GetHostAddresses("ManhKhoa");
            
            int count = 0;
            foreach (IPAddress IP in IPList)
            {
                richTextBox1.Text += count + ": " + IP.ToString() + "\n";
                count++;
            }
        }
    }
}
