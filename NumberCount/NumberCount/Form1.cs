using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NumberCount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static void main()
        {
            Thread t = new Thread(new ThreadStart(Method1));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static void Method1()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
