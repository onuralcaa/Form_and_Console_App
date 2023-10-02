using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiletSatisUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] cities = new string[] { "istanbul", "ankara", "osmaniye", "ordu", "giresun", "konya" };


        private void Form1_Load(object sender, EventArgs e)
        {
            comboFrom.Items.Add(cities[0]);
            comboFrom.Items.Add(cities[1]);
            MessageBox.Show(cities.Length + " farklı şehir bulunmaktadır.");       
        }

        private void comboFrom_SelectedValueChanged(object sender, EventArgs e)
        {
            comboTo.Items.Clear();
            comboTo.Text = " ";
            if (comboFrom.SelectedItem.ToString() == cities[0])
            {
                comboTo.Items.Add(cities[2]);
                comboTo.Items.Add(cities[3]);
            }

            else
            {
                comboTo.Items.Add(cities[4]);
                comboTo.Items.Add(cities[5]);
            }

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            string from = comboFrom.SelectedItem.ToString();
            string to = comboTo.SelectedItem.ToString();
            MessageBox.Show("Kalkış noktanız => " + from + " Varış noktanız => "+ to+" İyi uçuşlar.");
        }
    }
}
