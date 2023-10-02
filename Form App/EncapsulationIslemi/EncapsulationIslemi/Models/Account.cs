using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncapsulationIslemi.Models
{
    public class Account
    {
        string _userName;
        public string userName
        {

            get { return "Mr. "+ _userName; }
            set 
            { 
                if(value.Length > 4)
                {
                    _userName = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Kullanıcı adını en az 4 karakter girmelisiniz.");
                    Application.Restart();
                }
            
              
            }
        }

        public string Password { get; set; }








    }
}
