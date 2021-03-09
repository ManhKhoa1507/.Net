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

namespace FileLab
{
    public partial class ReadFile : Form
    {
        // OpenFileDialog : allow user to browe and select file on a computer in an application 

        OpenFileDialog ofd = new OpenFileDialog();
        FileStream fs;
        string content;
        byte[] bytes;

        public ReadFile()
        {
            InitializeComponent();
        }
        // Cách đọc sử dụng FileStream
        private void btnFileStream_Click(object sender, EventArgs e)
        {
            // Hiển thị Hộp thoại OpenFileDialog cho phép chọn 1 file
            // Thuộc tính FileName của OpenFileDialog trả về đường dẫn của file
            ofd.ShowDialog();
            fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);

            // 1 bytes la 1 chu cai 
            bytes = new byte[fs.Length];

            // Doc file tu vi tri dau tien den het file
            fs.Read(bytes, 0, (int)fs.Length);
            
            content = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
            richTextBox1.Text = content;
            //
        }

        // Cách đọc sử dụng StreamReader
        private void btnStreamReader_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            StreamReader StreamFile = new StreamReader(ofd.FileName);
            richTextBox1.Text = StreamFile.ReadToEnd();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private async void btnFileReadAsync_Click(object sender, EventArgs e)
        {
            //
        }

        private async void btnStreamReadAsync_Click(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //
        }

        private void ReadFile_Load(object sender, EventArgs e)
        {
            //
        }
    }
}


