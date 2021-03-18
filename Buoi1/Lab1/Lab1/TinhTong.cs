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
    public partial class TinhTong : Form
    {
        public TinhTong()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Sum 2 value
        public Int64 SumValue(int a, int b)
        {
            return a + b;
        }

        // Convert string to number
        public int ConvertNumber(string a)
        {
            return Convert.ToInt32(a);
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            try 
            {
                // Get 2 value
                int firstNumber = ConvertNumber(textBox1.Text);
                int secondNumber = ConvertNumber(textBox2.Text);
                
                Int64 sum = SumValue(firstNumber, secondNumber);

                // Display to richtextbox
                richTextBox1.Text = sum.ToString();
            }
            catch (Exception) 
            {
                // Show error message box
                MessageBox.Show("Vui lòng nhập số nguyên", "Error");
            }
        }
    }
}
