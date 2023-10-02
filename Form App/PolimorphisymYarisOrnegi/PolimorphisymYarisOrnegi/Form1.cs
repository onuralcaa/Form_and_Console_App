using PolimorphisymYarisOrnegi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace PolimorphisymYarisOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        Hasan hasan = new Hasan();
        Say say = new Say();
        Hüseyin hüseyin = new Hüseyin();
        Dirin dirin = new Dirin();
        Ihsan ihsan = new Ihsan();

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureDirin.Left += dirin.GetSpeed();
            pictureHasan.Left += hasan.GetSpeed();
            pictureHüseyin.Left += hüseyin.GetSpeed();
            pictureIhsan.Left += ihsan.GetSpeed();
            pictureSay.Left += say.GetSpeed();

            if(pictureDirin.Right >= labelFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("İlkay DİRİN KAZANDI.");
            }
            else if (pictureHasan.Right >= labelFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Hasan ATAL KAZANDI.");
            }
            else if (pictureHüseyin.Right >= labelFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Hüseyin ŞANVERDİ KAZANDI.");
            }
            else if (pictureIhsan.Right >= labelFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Ihsan ERDEM KAZANDI.");
            }
            else if (pictureSay.Right >= labelFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Mustafa SAY KAZANDI.");
            }
        }
    }
}
