using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw03_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = int.Parse(textBox1.Text);

            bool leapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            MessageBox.Show($"{year} is a leap year? {leapYear}");
        }
    }
}
