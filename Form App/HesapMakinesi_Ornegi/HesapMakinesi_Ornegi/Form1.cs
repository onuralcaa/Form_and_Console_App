using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi_Ornegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double number1, number2;
        double result;
        string op;

        private void btnPlus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textValue.Text);
            op = "+";
        }

        private void btnMines_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textValue.Text);
            op = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textValue.Text);
            op = "*";
        }

        private void btnDiviedby_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textValue.Text);
            op = "/";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hesap Makinesine hoşgediniz.");
        }

        private void Result_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(textValue.Text);
            
            if(op=="+")
            {
                result = number1 + number2;
            }

            else if(op == "-")
            {
                result = number1 - number2;
            }
            
            else if(op == "*")
            {
                result = number1 * number2;
            }

            else if(op == "/")
            {
                result = number1 / number2;
            }

            textValue.Text = result.ToString();

        }

        
    }
}
