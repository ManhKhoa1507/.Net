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
    public partial class ChuyenDoiSo : Form
    {
        public ChuyenDoiSo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChuyenDoiSo_Load(object sender, EventArgs e)
        {

        }
        
        // Convert Dec to 10, Bin to 2, Oct to 8, Hex to 16
        public int ConvertBaseToInt(string str)
        {
            int result = 0;
            
            switch (str)
            {
                case "Dec":
                    result = 10;
                    break;

                case "Bin":
                    result = 2;
                    break;

                case "Oct":
                    result = 8;
                    break;

                case "Hex":
                    result = 16;
                    break;
            }

            return result;
        }

        // Base convertion 
        public string ConvertNumber(string number, int fromBase, int toBase)
        {
            string result = "";
            int temp;

            temp = Convert.ToInt32(number, fromBase);
            result = Convert.ToString(temp, toBase);

            return result;
        }

        private void BaseConvert_Click(object sender, EventArgs e)
        {
            try
            {
                int fromBase, toBase;
                string number;

                number = textBox1.Text;
                fromBase = ConvertBaseToInt(comboBox1.Text);
                toBase = ConvertBaseToInt(comboBox2.Text);

                // Display to richTextBox
                string content = ConvertNumber(number, fromBase, toBase);
                richTextBox1.Text = content;
            }

            catch(Exception)
            {
                MessageBox.Show("Nhap gia tri hop le");
            }
        }
    }
}
