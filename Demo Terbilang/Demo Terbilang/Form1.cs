using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassTerbilang;

namespace Demo_Terbilang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nominal = int.Parse(angka.Text);
            Class1 terbilang = new Class1();
            Terbilang.Text = Convert.ToString(terbilang.TerbilangIndonesia(nominal));
        }
    }
}
