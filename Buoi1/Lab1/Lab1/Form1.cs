using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Run Bai 1
        private void Bai1_Click(object sender, EventArgs e)
        {
            TinhTong Bai_1 = new TinhTong();
            Bai_1.ShowDialog();
        }

        // Run Bai 2
        private void Bai2_Click(object sender, EventArgs e)
        {
            MinMax Bai_2 = new MinMax();
            Bai_2.ShowDialog();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            DocSo Bai_3 = new DocSo();
            Bai_3.ShowDialog();
        }
    }
}
