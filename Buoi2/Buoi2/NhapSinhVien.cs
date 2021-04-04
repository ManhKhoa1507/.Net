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
    public partial class NhapSinhVien : Form
    {
        bool firstLine = false;
        public NhapSinhVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private double StringToDouble(string str)
        {
            return Convert.ToDouble(str);
        }

        private void ClearTextBox()
        {
            // Clear the textbox
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void CheckFormat(string name, string studentCode, string phone, string mathPoint, string lecturePoint)
        {
            // Check the format

            if (name.Length > 20) throw new FormatException();
            if (studentCode.Length > 5) throw new FormatException();
            if (phone.Length > 20) throw new FormatException();

            double tempMathPoint = StringToDouble(mathPoint);
            double tempLecturePoint = StringToDouble(lecturePoint);

            if (tempLecturePoint > 10 || tempLecturePoint < 0) throw new FormatException();
            if (tempMathPoint > 10 || tempMathPoint < 0) throw new FormatException();
        }

        private async void Write_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the text in text box
                string name = textBox1.Text;
                string studentCode = textBox2.Text;
                string phone = textBox3.Text;
                string mathPoint = textBox4.Text;
                string lecturePoint = textBox5.Text;

                CheckFormat(name, studentCode, phone, mathPoint, lecturePoint);

                string message = "";
                
                // If it is the first line so there is no \n before thje cursor
                if(firstLine == true)
                {
                    message += "\n";
                }

                // esle
                message += studentCode + ";" + name + ";" + phone + ";"
                    + mathPoint + ";" + lecturePoint;

                firstLine = true;

                if(ThongTinSinhVien.ofd.FileName == "")
                {
                    throw new FileNotFoundException();
                }
             
                // Write the file and convert message to Upper case
                using (StreamWriter sw = new StreamWriter(ThongTinSinhVien.ofd.FileName, true))
                {
                    await sw.WriteAsync(message);
                }

                // Clear the text box
                ClearTextBox();
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn", "Error");
            }

            catch(FormatException)
            {
                MessageBox.Show("Vui lòng nhập lại dữ liệu", "Error");
            }

            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập lại", "Error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
