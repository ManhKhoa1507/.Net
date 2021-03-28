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
    public partial class DocSo : Form
    {
        public DocSo()
        {
            InitializeComponent();
        }

        // Change the number to string
        public string ReadNumber(int number)
        {
            string result = "";

            switch (number)
            {
                case 0: 
                    result = "Không";
                    break;

                case 1:
                    result = "Một";
                    break;

                case 2:
                    result = "Hai";
                    break;

                case 3:
                    result = "Ba";
                    break;

                case 4:
                    result = "Bốn";
                    break;
                case 5:
                    result = "Năm";
                    break;

                case 6:
                    result = "Sáu";
                    break;
                case 7:
                    result = "Bảy";
                    break;

                case 8:
                    result = "Tám";
                    break;

                case 9:
                    result = "Chín";
                    break;
            }
            return result;
        }

        // Convert string to Int32
        public int ConvertToInt(string a)
        {
            int result = Convert.ToInt32(a);
            return result;
        }

        // Read number
        private void Read_Click(object sender, EventArgs e)
        {
            try
            {

                int number = ConvertToInt(textBox1.Text);

                // if the number is unvalid
                if (number < 0 || number > 9)
                {
                    throw new ArgumentException();
                }
                else
                {
                    string readNumber = ReadNumber(number);
                    richTextBox1.Text = readNumber;
                }
            }

            // Show error message box
            catch (ArgumentException)
            {
                MessageBox.Show("Vui lòng nhập giá trị phù hợp từ 0 - 9");
            }
        }

        // Delete the textbox
        private void Delete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            richTextBox1.Text = "";
        }

        // Exit the current form
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
