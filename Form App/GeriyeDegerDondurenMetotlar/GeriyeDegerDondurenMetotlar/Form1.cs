using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeriyeDegerDondurenMetotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string GetName()
        {
            return "Onur";
        }

        public int Calculate(int number1, int number2)
        {
            int number = number1 * number2;
            return number;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetName());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Calculate(4,5).ToString());
        }
    }
}
