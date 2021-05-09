using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bai01_Click(object sender, EventArgs e)
        {
            Bai1 bai01 = new Bai1();
            bai01.ShowDialog();
        }

        private void Bai02_Click(object sender, EventArgs e)
        {
            Bai2 bai02 = new Bai2();
            bai02.ShowDialog();
        }
    }
}
