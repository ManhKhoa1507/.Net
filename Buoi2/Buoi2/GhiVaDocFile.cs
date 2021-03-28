using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
using Microsoft.SqlServer.Server;

namespace Buoi2
{
    public partial class GhiVaDocFile : Form
    {
        Char[] buffer;
        OpenFileDialog ofd = new OpenFileDialog();

        public GhiVaDocFile()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayToTextBox(string content)
        {
            // Display to text box
            textBox1.Text = content;
        }

        private async void readButton_Click(object sender, EventArgs e)
        {
            // Click the button to read the file using the async StreamReader

            ofd.ShowDialog();

            // Read the file
            using (StreamReader sr = new StreamReader(ofd.FileName))
            {
                int srLength = (int)sr.BaseStream.Length;
                buffer = new Char[srLength];
                    
                // Read to the end of file
                await sr.ReadAsync(buffer, 0, srLength);
            }

            // Display to text box
            string bufferString = new string(buffer);
            DisplayToTextBox(bufferString);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Click button to save the file 

            ofd.ShowDialog();

            // Get the text in text box
            string message = textBox1.Text;

            // Write the file and convert message to Upper case
            using (StreamWriter sw = new StreamWriter(ofd.FileName))
            {
                await sw.WriteAsync(message.ToUpper());
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
