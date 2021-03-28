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
    public partial class ThongTinFile : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        char[] buffer;

        public ThongTinFile()
        {
            InitializeComponent();
        }

        private void DisplayToRichTextBox(string fileName, string directoryPath,
            int line, int word, int character)
        {
            // Display to RichTextBox;

            FileName.Text = fileName;
            URL.Text = directoryPath;
            Lines.Text = IntToString(line);
            Words.Text = IntToString(word);
            Characters.Text = IntToString(character);
        }

        public string IntToString(int number)
        {
            return number.ToString();
        }

        private static string[] ReplaceTemp(string message)
        {
            // Replace '.', '?', '!', ' ', ';', ':', ','
            // Return new string
            message = message.Replace('\r', ' ');
            string[] result = message.Split(new char[] { '.', '?', '!', ' ', ';',
':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            return result;
        }

        private static (int lines, int words, int characters) CountElement(string message)
        {
            // Count lines, words, characters in message
            // Return lines, words, characters
            int words = 0;
            int characters = message.Length;
            int lines = message.Split('\n').Length;

            string[] tempMessage = ReplaceTemp(message);
            words = tempMessage.Count();
            return (lines, words, characters);
        }

        private async void Read_Click(object sender, EventArgs e)
        {
            // Click to read the file
            ofd.ShowDialog();
       
            string fileName = ofd.FileName;
            string directoryPath = Path.GetDirectoryName(fileName);
            int lines = 0, words = 0, characters = 0;

            // Read the file 
            using (StreamReader sr = new StreamReader(fileName))
            {
                int srLength = (int)sr.BaseStream.Length;
                buffer = new Char[srLength];

                await sr.ReadAsync(buffer, 0, srLength);
            }

            // Convert buffer to string 
            string message = new string(buffer);

            // Count element 
            (lines, words, characters) = CountElement(message);

            // Display result;
            richTextBox1.Text = message;
            DisplayToRichTextBox(fileName, directoryPath, lines, words, characters);
        }
    }
}
