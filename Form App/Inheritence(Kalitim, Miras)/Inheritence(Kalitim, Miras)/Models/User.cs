using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Kalitim__Miras_.Models
{
    public class User //oluşturulan bu sınıfın ortak miras sınıfı olabilmesi için public tanımlanması gerekiyor.
    {
        
        public User(string _userName, string _Password)
        {
           userName = _userName;
           Password = _Password;
        }
        public string userName { get; set; }
        public string Password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }

        public string getFullName()
        {
            return $"{firstName} {lastName}";
        }
    }
}
