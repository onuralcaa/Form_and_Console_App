using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beni buldun.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yanlış kutu.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yanlış kutu.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yanlış kutu.");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }
    }
}
