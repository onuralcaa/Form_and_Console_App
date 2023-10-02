using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginIslemi.models
{
    public class user 
    {
        public string userName { get; set; }
        public string passWord { get; set; }


        public void Login(string LoginDate)
        {
            System.Windows.Forms.MessageBox.Show($"{userName} adlı kullanıcı {LoginDate} tarihinde {passWord} şifresi ile giriş yaptı.");
        }
    }

    


}
