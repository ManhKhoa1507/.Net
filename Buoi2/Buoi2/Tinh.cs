using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Buoi2
{
    public partial class Tinh : Form
    {
        Char[] buffer;
        OpenFileDialog ofd = new OpenFileDialog();

        public Tinh()
        {
            InitializeComponent();
        }

        private void DisplayToRichTextBox(string content)
        {
            // Display to RichTextBox
            richTextBox1.Text = content;
        }

        private async void Read_Click(object sender, EventArgs e)
        {
            // Click the button to read the file using the async StreamReader

            ofd.ShowDialog();

            // Read the file
            using (StreamReader sr = new StreamReader(ofd.FileName))
            {
                int srLength = (int)sr.BaseStream.Length;
                buffer = new Char[srLength];

                // Read to the end of file
                await sr.ReadAsync(buffer, 0, srLength);
            }

            // Display to text box
            string bufferString = new string(buffer);
            DisplayToRichTextBox(bufferString);
        }

        private async void Write_Click(object sender, EventArgs e)
        {

            // Click button to save the file 
            ofd.ShowDialog();

            // Get the text in text box
            string message = richTextBox2.Text;

            // Write the file and convert message to Upper case
            using (StreamWriter sw = new StreamWriter(ofd.FileName))
            {
                await sw.WriteAsync(message.ToUpper());
            }
        }

        private static int StringToInt(string str)
        {
            // Convert string to int 
            // return int type of str
            return Convert.ToInt32(str);
        }

        private string IntToString(int value)
        {
            // Convert int to string
            // Return string of int value 
            return value.ToString();
        }

        private int StringCalculate(int a, int b, string _operator)
        {
            // Calculate (a+b) or (a-b) or (a*b) or (a/b) or (a%b) 
            //  with the given operator

            int result = 0;

            switch (_operator)
            {
                case "+":
                    result = a + b;
                    break;

                case "-":
                    result = a - b;
                    break;

                case "*":
                    result = a * b;
                    break;

                case "/":
                    result = a / b;
                    break;

                case "%":
                    result = a % b;
                    break;

                default:
                    throw new Exception();
            }
            return result; 
        }


        private static (int firstNumber, int SecondNumber, string _operator) SplitString(string str)
        {
            // Split the string to list
            List<string> splitedString = str.Split(' ').ToList();

            if(splitedString.Count != 3)
            {
                throw new Exception();
            }

            // return firstNumber, secondNumber, _operator in the str
            int firstNumber = StringToInt(splitedString[0]);
            int secondNumber = StringToInt(splitedString[2]);
            string _operator = splitedString[1];

            return (firstNumber, secondNumber, _operator);
        }

        private void DisplayResult(int result, string line)
        {
            // Display result to rich text box 2
            richTextBox2.Text += line + " = ";
            richTextBox2.Text += IntToString(result);
            richTextBox2.Text += "\n";
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Text = "";

                // Splite the line in the richTextBox
                string[] lines = richTextBox1.Text.Split('\n');

                foreach (string line in lines)
                {
                    // get firstNumber, secondNumber, _operator
                    int firstNumber = 0;
                    int secondNumber = 0;
                    string _operator = "";

                    (firstNumber, secondNumber, _operator) = SplitString(line);

                    // Calculate
                    int result = StringCalculate(firstNumber, secondNumber, _operator);
                    
                    // Display result to richTextBox
                    DisplayResult(result, line);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập lại", "error");
            }
        }
    }
}
