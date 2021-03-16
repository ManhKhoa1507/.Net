using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace IpAddress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void KiemTra()
        {
            IPAddress ip;
            String Ip4 = "127.0.0.1";
            String Ip5 = "999.0.0.1";
            MessageBox.Show(Ip4.ToString() + ": " +
            IPAddress.TryParse(Ip4, out ip).ToString());
            MessageBox.Show(Ip5.ToString() + ": " +
            IPAddress.TryParse(Ip5, out ip).ToString());
        }
    }
}
