using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textNumber1.Text);
            double number2 = Convert.ToDouble(textNumber2.Text);
            string sonuc = (number1 + number2).ToString();
            MessageBox.Show("Sonuç : " +sonuc);
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textNumber1.Text);
            double number2 = Convert.ToDouble(textNumber2.Text);
            string sonuc = (number1 - number2).ToString();
            MessageBox.Show("Sonuç : " + sonuc);
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textNumber1.Text);
            double number2 = Convert.ToDouble(textNumber2.Text);
            string sonuc = (number1 * number2).ToString();
            MessageBox.Show("Sonuç : " + sonuc);
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textNumber1.Text);
            double number2 = Convert.ToDouble(textNumber2.Text);
            string sonuc = (number1 / number2).ToString();
            MessageBox.Show("Sonuç : " + sonuc);
        }
    }
}
