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
    public partial class QuanLiDiem : Form
    {
        const string formatError = "Sai format vui long nhap lai";
        const string exceptionError = "vui long nhap lai";

        public QuanLiDiem()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        // Check the format
        // Return 0 if end with "," else return 1
        public void CheckFormat(string str)
        {
            if(str == "" || str.EndsWith(","))
            {
                throw new FormatException();
            }
        }

        public void CheckGrade(List<float> gradeList)
        {
            foreach(float grade in gradeList)
            {
                if (grade < 0 || grade > 10)
                {
                    throw new FormatException();
                }
            }
        }

        // Display diem so to richTextBox
        public void DisplayGradeList(List<float> gradeList)
        {
            string result = "";
            int count = 0;

            // If there is 4 item in 1 line then create new line in result
            // Else create tab
            foreach(float grade in gradeList)
            {
                count++;
                result += "Môn " + count + ": " + grade + "đ\t";

                if (count % 4 == 0)
                {
                    result += "\n";
                }
            }

            // Display to richTextBox
            richTextBox1.Text = result;
        }

        // Calculate the average grade 
        public float CalculateAverage (List <float> gradeList)
        {

            float sum = 0;

            foreach(float grade in gradeList)
            {
                sum += grade;
            }
            float average = sum/gradeList.Count;
            return average;
        }

        // Find max grade in grade list
        public float FindMax(List<float> gradeList)
        {
            float max = 0;

            foreach(float grade in gradeList)
            {
                if(grade > max)
                {
                    max = grade;
                }
            }

            return max;
        }

        // Find min grade in grade list
        public float FindMin(List<float> gradeList)
        {
            float min = 10;

            foreach (float grade in gradeList)
            {
                if (grade < min)
                {
                    min = grade;
                }
            }
            return min;
        }

        // Count the failed and pass grade
        // < 5 failed
        // > 5 pass
        public static(int failed, int pass) CountGrade(List<float> gradeList)
        {
            int failedCount = 0;
            int passCount = 0;

            foreach(float grade in gradeList)
            {
                if (grade < 5) failedCount++;
                else passCount++;
            }

            return (failedCount, passCount);
           
        }

        // Check the student's Rate
        public string CheckRate(List<float> gradeList, float average, float minGrade)
        {
            List<string> studyRate = new List<string> { "Kém", "Yếu", "Trung bình", "Khá", "Giỏi" };
            int rate = 0;

            // Gioi if average >= 8 and no grade < 6.5 
            if (average >= 8)
            {
                rate = 4;
                if (minGrade < 6.5)
                {
                    rate --;
                }
            }

            // Kha if average >= 6.5 and no grade < 5 
            else if (average >= 6.5)
            {
                rate = 3;
                if (minGrade < 5)
                {
                    rate--;
                }
            }

            // TB if average >= 5 and no grade < 3.5 
            else if (average >= 5)
            {
                rate = 2;
                if (minGrade < 3.5)
                {
                    rate--;
                }
            }

            // Yeu if average > 3.5 and no grade < 2
            if (average >= 3.5)
            {
                rate = 1;
                if (minGrade < 2)
                {
                    rate--;
                }
            }
            // Else Kem

            // Return the student's rate
            return studyRate[rate];
        }

        // Display diem trung binh, diem cao nhat, so mon khong dau
        // xep loai hoc luc, mon co diem thap nhat, so mon khong dau, so mon dau 
        public void DisplayItem(List <float> gradeList)
        {
            float average = CalculateAverage(gradeList);
            float maxGrade = FindMax(gradeList);
            float minGrade = FindMin(gradeList);

            (int fail, int pass) = CountGrade(gradeList);

            string studentRate = CheckRate(gradeList, average, minGrade);

            GradeAverage.Text = "Điểm trung bình: " + average;
            MaxGrade.Text = "Điểm cao nhất: " + maxGrade;
            FailedCount.Text = "Số môn không đậu: " + fail;
            Power.Text = "Xếp loại học lực: " + studentRate;
            MinGrade.Text = "Điểm thấp nhất: " + minGrade;
            PassCount.Text = "Số môn đậu: " + pass;
        }

        private void Run_Click(object sender, EventArgs e)
        {
            try
            {
                // String split
                string input = textBox1.Text;
                CheckFormat(input);

                // Convert to float list
                List<float> gradeList = input.Split(',').Select(float.Parse).ToList();
                CheckGrade(gradeList);                

                DisplayGradeList(gradeList);
                DisplayItem(gradeList);
            }

            catch(FormatException)
            {
                MessageBox.Show(formatError, "Error");
            }
            catch(Exception)
            {
                MessageBox.Show(exceptionError, "Error");
            }
    
        }

        private void DiemTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuanLiDiem_Load(object sender, EventArgs e)
        {

        }

        private void PassCount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
