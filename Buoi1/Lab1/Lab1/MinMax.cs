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
        public double FindMax(double a, double b, double c)
        {
            double max = a;

            if(max < b) 
            {
                max = b;
            }

            if(max < c)
            {
                max = c;
            }

            return max;
        }

        // Find Min between 3 number
        public double FindMin(double a, double b, double c)
        {
            double min = a;

            if (min > b)
            {
                min = b;
            }

            if (min > c)
            {
                min = c;
            }

            return min;
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

                // Find max and min value
                double max = FindMax(firstNumber, secondNumber, thirdNumber);
                double min = FindMin(firstNumber, secondNumber, thirdNumber);

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
        }

        // Exit the MinMax form
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
