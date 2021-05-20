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
using System.IO;

namespace Buoi4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }
        private string GetHTML(string url)
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

        private async void WriteFile(string location, string message)
        {

            // Write the file and convert message to Upper case
            using (StreamWriter sw = new StreamWriter(location))
            {
                await sw.WriteAsync(message);
            }
        }

        private void RenderWeb(WebBrowser web, string url)
        {
            web.Navigate(url);
        }

        private void Go_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;

            RenderWeb(webBrowser1, url);
        }
    }
}
