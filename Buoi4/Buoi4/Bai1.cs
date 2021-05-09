using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Resources;
using System.IO;
using System.Net.Sockets;


namespace Buoi4
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private string getHTML(string url)
        {
            // get request form the web 
            WebRequest request = WebRequest.Create(url);
            WebResponse respone = request.GetResponse();
            Stream dataStream = respone.GetResponseStream();
            
            // Use the stream reader to read the source code
            StreamReader reader = new StreamReader(dataStream);
            string responeFromServer = reader.ReadToEnd();
            
            // Close the connection
            respone.Close();
           
            return responeFromServer;
        }

        private void GetHTML_Click(object sender, EventArgs e)
        {
            try
            {
                string url = textBox1.Text;
                richTextBox1.Text = getHTML(url);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
