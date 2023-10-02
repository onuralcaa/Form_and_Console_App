using ConstructorYapiciMetotlarOrnek.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructorYapiciMetotlarOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        User user;
        private void Constructor_Load(object sender, EventArgs e)
        {
            user = new User("onur", "123");

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = textUserName.Text;
            string password = textPassword.Text;

            if(UserName == user.userName && password == user.password)
            {
                Form2 login = new Form2(user);
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız.");
            }

        }
    }
}
