using EncapsulationIslemi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncapsulationIslemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            Account account= new Account();

            account.userName = textuserName.Text;
            account.Password = textpassword.Text;
            MessageBox.Show($"Kullanıcı başarılı bir şekilde oluşturulmuştur. Kullanıcı adı : {account.userName}");
        }
    }
}
