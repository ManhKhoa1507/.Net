using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            GhiVaDocFile Bai1 = new GhiVaDocFile();
            Bai1.ShowDialog();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            ThongTinFile Bai2 = new ThongTinFile();
            Bai2.ShowDialog();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            Tinh Bai3 = new Tinh();
            Bai3.ShowDialog();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            ThongTinSinhVien Bai4 = new ThongTinSinhVien();
            Bai4.ShowDialog();
        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            DuyetThuMuc Bai5 = new DuyetThuMuc();
            Bai5.ShowDialog();
        }
    }
}
