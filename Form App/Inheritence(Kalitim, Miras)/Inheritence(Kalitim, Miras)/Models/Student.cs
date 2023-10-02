using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Kalitim__Miras_.Models
{
    public class Student : User
    {
        

        public Student(string _studentNumber,string _userName, string _Password) : base(_userName, _Password)
        {
            studentNumber = _studentNumber;
        }

        public string classRoom { get; set; }
        public string studentNumber { get; set; }

        public void doHomework()
        {
            System.Windows.Forms.MessageBox.Show("Ödev yapılıyor.");
        }


    }
}
