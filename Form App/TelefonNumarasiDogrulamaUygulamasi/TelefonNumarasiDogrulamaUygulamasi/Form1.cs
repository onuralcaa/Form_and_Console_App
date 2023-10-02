using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonNumarasiDogrulamaUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumberCheck_Click(object sender, EventArgs e)
        {
            string onurNumber = txtNumber.Text;
            string phoneLast = CheckPhone(onurNumber);

            if(phoneLast.Contains("Hata"))
            {
                MessageBox.Show($"{phoneLast} numaralı telefona mesaj gönderilmiştir.");
            }
            else
            {
                MessageBox.Show("Telefon numarası başarılı bir şekilde kaydedilmiştir.");
            }
        }

        public string CheckPhone(string phone)
        {
            try
            {
                if (phone == "")
                {
                    return "HATA ->Lütfen telefon numarası alanını doldurunuz.";
                }
                phone = phone.Replace(" ", "");
                phone = phone.Replace("+", "");
                string firstCharacter = phone.Substring(0, 1);
                if (firstCharacter == "9")
                {
                    phone = phone.Substring(1, phone.Length - 1);
                }
                else if (firstCharacter != "0")
                {
                    phone = "0" + phone;
                }
                if (phone.Length == 11)
                {
                    Convert.ToDouble(phone);
                    return phone;
                }
                return "Hata mesajı -> lütfen girdiğiniz formatı kontrol ediniz.";
            }
            catch (FormatException)
            {
                return "Hata mesajı -> lütfen uygun bir format giriniz.";
              
            }
            catch(Exception) 
            {
                return "Hata mesajı -> lütfen telefon numrasını giriniz.";
            }
            

        }

        ///05553332222
        ///
        ///0555 333 22 22
        ///+90555345435
        ///904354523442
        ///5555245255
        ///dsdadasdasd
        ///Bu ihtimallerin önüne geçilmesi düşünülecektir.


    }
}
