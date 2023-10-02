using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Kalitim__Miras_.Models
{
    public class Teacher : User //teacher sınıfı artık User sınıfından miras alıyor.
    {
        public Teacher(string _userName, string _Password) : base(_userName, _Password)
        {
        }

        public string[] classRooms { get; set; }  
        public string branch { get; set; }


        public void giveHomework()
        {
            System.Windows.Forms.MessageBox.Show("Ödev verildi.");
        }












    }
}
