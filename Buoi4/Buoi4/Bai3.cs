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
    public partial class Bai3 : Form
    {
        Char []buffer;

        public Bai3()
        {
            InitializeComponent();
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

        private void ShowRichTextBox(RichTextBox box, string message)
        {
            // Show the message to the rich text box
            box.Text = "";
            box.Text = message;
        }

        private void Download_Click(object sender, EventArgs e)
        {
            // Get the url and location 
            string url = textBox1.Text;
            string location = textBox2.Text;
            
            try
            {
                string sourceCode = GetHTML(url);

                // Show the message to richtextbox and write the file 
                ShowRichTextBox(richTextBox1, sourceCode);
                WriteFile(location, sourceCode);
            }

            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
