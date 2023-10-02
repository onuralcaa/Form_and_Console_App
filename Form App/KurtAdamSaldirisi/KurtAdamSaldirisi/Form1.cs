using KurtAdamSaldirisi.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KurtAdamSaldirisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         Account Player = new Account();
        private void btnSelect_Click(object sender, EventArgs e)
        {
            textUserName.Clear();
            textWeapon.Clear();

            Player.userName = textUserName.Text;
            Player.weapon = textWeapon.Text;
            Player.branch = cbmBranch.SelectedItem.ToString();
            Player.race = cmbRace.SelectedItem.ToString();

            ChangeState(false);
            ChangeVisible(true);
        }

        public void ChangeState(bool state)
        {
            textUserName.Enabled= state;
            textWeapon.Enabled= state;
            cbmBranch.Enabled= state;
            cmbRace.Enabled= state;
            btnSelect.Enabled= state;
        }


        public void ChangeVisible(bool isVisible)
        {
            btnAttack.Visible= isVisible;
            pictureBoxWolfMan.Visible= isVisible;
            lblHealth.Visible= isVisible;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            Player.Attack();
            lblHealth.Width -= Convert.ToInt32(Player.damage);
            MessageBox.Show($"Düşmana {Player.damage} kadar hasar verdiniz.");

            if(lblHealth.Width <= 0)
            {
                MessageBox.Show("Düşmanı yendiniz.");
                pictureBoxWolfMan.Visible= false;

            }



        }
    }
}
