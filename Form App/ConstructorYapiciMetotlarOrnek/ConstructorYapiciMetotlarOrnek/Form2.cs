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
    public partial class Form2 : Form
    {
        public Form2(User _user)
        {
            InitializeComponent();
            user = _user;
        }

        User user;
        private void Form2_Load(object sender, EventArgs e)
        {
            labelMessage.Text = $"Hoşgeldiniz {user.userName}";
        }
    }
}
