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

namespace FileLab
{
    public partial class ReadFile : Form
    {

        // OpenFileDialog : allow user to browe and select file on a computer in an application 
        OpenFileDialog ofd = new OpenFileDialog();
        FileStream fs;
        string content;
        byte[] bytes;
        Char[] buffer;

        public ReadFile()
        {
            InitializeComponent();
        }
        // Cách đọc sử dụng FileStream Sync
        private void btnFileStream_Click(object sender, EventArgs e)
        {

            // Hiển thị Hộp thoại OpenFileDialog cho phép chọn 1 file
            // Thuộc tính FileName của OpenFileDialog trả về đường dẫn của file
            ofd.ShowDialog();
            
            // Use using to not to close the fs
            using (FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate))
            {
                int fsLength = (int)fs.Length;
                // 1 bytes = 1 word
                bytes = new byte[fsLength];

                // Read file from begin to end
                fs.Read(bytes, 0, fsLength);
            }

            // Encoding the content in the file
            // UTF-8 supported the Vietnamese
            string content = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
            Display_richTextBox(content);
            //
        }

        // Cách đọc sử dụng StreamReader Sync
        private void btnStreamReader_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            StreamReader sr = new StreamReader(ofd.FileName);

            // Read to the end of file 
            Display_richTextBox(sr.ReadToEnd());

            sr.Close();
        }

        // Read the file using FileStream Async
        private async void btnFileReadAsync_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();

            using (FileStream fs = File.Open(ofd.FileName, FileMode.Open))
            {
                int fsLength = (int)fs.Length;
                bytes = new byte[fsLength];

                // Await for read the file async 
                // Read to end of file
                await fs.ReadAsync(bytes, 0, fsLength);
            }
            string content = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
            Display_richTextBox(content);
        }

        // Read the file using StreamReader Async
        private async void btnStreamReadAsync_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog(); 

            using (StreamReader sr = new StreamReader(ofd.FileName))
            {
                int srLength = (int)sr.BaseStream.Length;
                buffer = new Char[srLength];

                // Read to the end of file
                await sr.ReadAsync(buffer, 0, srLength);
            }

            // Create a bufferString array and display to richTextBox
            string bufferString = new string(buffer);
            Display_richTextBox(bufferString);
        }

        // Clear the richTextBox
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Make the richTextBox = ""
            richTextBox1.Text = "";
        }


        // Open new form
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Open new Databaseform 
            DatabaseForm Dbform = new DatabaseForm();
            Dbform.ShowDialog();
        }

        private void ReadFile_Load(object sender, EventArgs e)
        {

        }

        // Display the content to the richTextBox
        public void Display_richTextBox(string content)
        {
            richTextBox1.Text = content;
        }
    }
}


