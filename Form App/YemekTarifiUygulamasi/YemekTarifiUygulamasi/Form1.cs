using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekTarifiUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] stages = { "1-suyu koy", "2-tuz koy", "3-ocağı aç", "4-karıştır", "5-salça koy", "6-afiyet olsun" };

        int index  = 0;
        private void btnAddStage_Click(object sender, EventArgs e)
        {
            if(index < stages.Length)
            {
                lstStages.Items.Add(stages[index++]);
                //index++; ikiside aynı şey
            }
            else
            {
                MessageBox.Show("Tarif tamamlanmıştır.");
            }
            
        }
    }
}
