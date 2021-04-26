using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            Bai01 bai01 = new Bai01();
            bai01.ShowDialog();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            telnet bai02 = new telnet();
            bai02.ShowDialog();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            Tcp bai03 = new Tcp();
            bai03.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
