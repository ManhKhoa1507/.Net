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
            //
        }

        // Cách đọc sử dụng StreamReader
        private void btnStreamReader_Click(object sender, EventArgs e)
        {
            //
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


