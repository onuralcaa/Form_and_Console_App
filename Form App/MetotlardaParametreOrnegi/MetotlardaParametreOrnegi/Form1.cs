using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace MetotlardaParametreOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string value;
        int damage;
        public void DamageOfAttack(string value, int damage)
        {
            /*switch (value)
            {
                case "okçu":
                    MessageBox.Show("Okçu ile hasar verdiniz.");
                    break;

                case "büyücü":
                    MessageBox.Show("Büyücü ile hasar verdiniz.");
                    break;

                case "savaşçı":
                    MessageBox.Show("Savaşçı ile hasar verdiniz.");
                    break;

                default:
                    MessageBox.Show("Onur ALACA");
                    break;
            }
            */

            MessageBox.Show($"Düşmana {value} ile {damage} hasar verdiniz.");
        }
        private void btnArcher_Click(object sender, EventArgs e)
        {
            value = "okçu Onur";
            damage = 200;
            DamageOfAttack(value, damage);
        }

        private void btnMage_Click(object sender, EventArgs e)
        {
            value = "büyücü İhsan";
            damage = 250;
            DamageOfAttack(value, damage);
        }
        /// <summary>
        /// Buraya alttaki fonksiyon hakkında yorum yapabilirsiniz.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWarrior_Click(object sender, EventArgs e)
        {
            value = "savaşçı Canberk";
            damage = 300;
            DamageOfAttack(value , damage);
        }
       
        
    }
}
