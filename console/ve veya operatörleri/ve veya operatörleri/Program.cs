using System;

namespace ve_veya_operatorleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdi, email, sifre;
            kullaniciAdi = "onuralcaa";
            email = "onuralcaa@gmail.com";
            sifre = "Ankara06";
            Console.WriteLine("Kullanıcı adınızı veya email adresinizi giriniz : ");
            string isim1=Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz : ");
            string sifre1=Console.ReadLine();
            bool isTrue = (isim1 == kullaniciAdi&& sifre==sifre1);
            Console.WriteLine(isTrue);

        }
    }
}
