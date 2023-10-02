using System;

namespace Tip_dönüşümleri_örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kısa kenar uzunluğunu giriniz :");
            int kisaKear = Convert.ToInt32(Console.ReadLine());//ReadLine(); komutu ile alınan string ifadenin int tipine cast edilmesi gerekiyor.
            Console.WriteLine("Uzun kenar uzunluğunu giriniz :");
            int uzunKenar = Convert.ToInt32(Console.ReadLine());//ReadLine(); komutu ile alınan string ifadenin int tipine cast edilmesi gerekiyor.
            //string cevre = ((kisaKear + uzunKenar)*2).ToString(); //alternatif1
            int cevreInt = ((kisaKear + uzunKenar) * 2); //alternatif 2

            Console.WriteLine("Dikdörtgenimizin çevresi :" + cevreInt);



        }
    }
}
