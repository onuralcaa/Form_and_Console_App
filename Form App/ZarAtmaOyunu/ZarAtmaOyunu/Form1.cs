using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAtmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1, number2;
            string message = Play(out number1 , out number2);

            MessageBox.Show(message);
            label3.Text = number1.ToString();
            label4.Text = number2.ToString();


        }

        public string Play(out int number1 ,out int number2)
        {
            string message;
            Random random = new Random();
            number1 = random.Next(0,6);
            number2= random.Next(0,6);
            if(number1 == number2)
            {
                message = "Kazandınız.";
            }
            else
            {
                message = "Kaybettiniz.";
            }
            return message;
        }


    }
}
