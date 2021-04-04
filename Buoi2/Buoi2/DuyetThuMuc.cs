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
    public partial class DuyetThuMuc : Form
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        public DuyetThuMuc()
        {
            InitializeComponent();
        }

        private void DuyetThuMuc_Load(object sender, EventArgs e)
        {

        }

        private string getFileName(string file)
        {
            // Just get the file name 
            List<string> tempList = file.Split('.').ToList();
            return tempList[0];
        }

        private void AddItem(FileInfo fi)
        {
            // Add item to listView
            ListViewItem item = new ListViewItem();
            item.Text = getFileName(fi.Name);
            listView1.Items.Add(item);

            // Create and add subitems
            ListViewItem.ListViewSubItem subItemSize = new ListViewItem.ListViewSubItem(item, fi.Length.ToString());
            ListViewItem.ListViewSubItem subItemExtention = new ListViewItem.ListViewSubItem(item, fi.Extension);
            ListViewItem.ListViewSubItem subItemDate = new ListViewItem.ListViewSubItem(item, fi.CreationTime.ToString());

            item.SubItems.Add(subItemSize);
            item.SubItems.Add(subItemExtention);
            item.SubItems.Add(subItemDate);
        }

        private void GetFileInfo(string path)
        {
            // Get the list of file in the folder
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fileArray = di.GetFiles();

            foreach (FileInfo file in fileArray)
            {
                // Add the file info to listView
                AddItem(file);
            }
        }

        private void DirectoryInfoClick_Click(object sender, EventArgs e)
        {
            try
            {
                // Get folder path and get the file info 
                fbd.ShowDialog();
                GetFileInfo(fbd.SelectedPath);
            }
            catch
            {
                MessageBox.Show(" Vui lòng chọn folder khác");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
