using LoginIslemi.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginIslemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user user1= new user();

            user1.userName = textBox1.Text;
            user1.passWord = textBox2.Text;

            string loginDate = DateTime.Now.ToString();

            user1.Login(loginDate);
          
        }
    }
}
