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
    public partial class MinMax : Form
    {
        public MinMax()
        {
            InitializeComponent();
        }

        // Find Max between 3 number
        public static (double min, double max) FindMinMax(List<double> doubleList)
        {
            double max = doubleList.Max();
            double min = doubleList.Min();

            return (min, max);

        }

        // Convert string value to double 
        public double convertNumber(string a)
        {
            double result = Convert.ToDouble(a);
            return result;
        }

        private void Find_Click(object sender, EventArgs e)
        {
            try
            {
                // Get 3 value
                double firstNumber = convertNumber(textBox1.Text);
                double secondNumber = convertNumber(textBox2.Text);
                double thirdNumber = convertNumber(textBox3.Text);

                List<double> doubleList = new List<double> { firstNumber, secondNumber, thirdNumber };

                // Find max and min value
                (double min, double max) = FindMinMax(doubleList);

                // Display to richtextbox
                richTextBox1.Text = max.ToString();
                richTextBox2.Text = min.ToString();
            }
            catch (Exception)
            {
                // Show error Message
                MessageBox.Show("Nhap so nguyen");
            }
        }

        // Clear all textbox
        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

        // Exit the MinMax form
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
