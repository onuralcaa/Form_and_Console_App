using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGenerate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        private void randombuton_Click(object sender, EventArgs e)
        {
            int number = random.Next(0,11);
            MessageBox.Show(number.ToString());
        }
    }
}
