using OOP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            user User = new user();

            User.job = "student";
            User.userName = "Onur";
            User.age = 22;
            User.password = "1234";

            MessageBox.Show($"kullanıcı adı : {User.userName} şifresi : {User.password}");



            //user User2 = new user();//yeni kullanıcı oluşturma.



        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            tree Tree = new tree();

            Tree.type = "elma";
            Tree.height = 172;
            Tree.age = 23;

            MessageBox.Show($"türü : {Tree.type} yaşı : {Tree.age}");


        }
    }
}
