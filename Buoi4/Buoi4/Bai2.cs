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
    public partial class Bai2 : Form
    {
        public Bai2()
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

        private void GetHeader(string url)
        {
            // Get the header
            WebClient myClient = new WebClient();
            byte[] response = myClient.DownloadData(url);
            WebHeaderCollection webHeader = myClient.ResponseHeaders;
            string[] headers = webHeader.AllKeys;

            // Create the listView
            listView1.Items.Clear();
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            // Display the header to list view
            int i = 0;
            foreach(string s in headers)
            {
                i++;
                item = new ListViewItem(i.ToString());

                subItems = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item,s),
                    new ListViewItem.ListViewSubItem(item, webHeader.Get(s))
                };
                
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
        }

        private void ShowRichTextBox(RichTextBox box, string str)
        {
            // Display to rich text box
            box.Text = "";
            box.Text = str;
        }

        private void Download_Click(object sender, EventArgs e)
        {
            // Get the url from text box 
            string url = textBox1.Text;

            string sourceCode = GetHTML(url);
            ShowRichTextBox(richTextBox1, sourceCode);

            GetHeader(url);
        }
    }
}
