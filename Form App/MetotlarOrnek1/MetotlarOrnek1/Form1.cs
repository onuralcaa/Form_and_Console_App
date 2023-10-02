using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetotlarOrnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int number=0;
        public void numberdecrement()
        {
            number--;
        }
        public void numberIncrement()
        {
            number++;
        }
        private void btnDecrement_Click(object sender, EventArgs e)
        {
            number = 0;
            numberdecrement();
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            numberIncrement();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("şu anda : "+number);
        }
    }
}
