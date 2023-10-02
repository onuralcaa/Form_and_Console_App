using System;

namespace Sayı_tahmin_eden_uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aklından bir sayı tut");
            Console.ReadLine();// enter tuşuna basana kadar bekler.
            Console.WriteLine("Tuttuğun sayıyı iki ile çarp");
            Console.ReadLine();//enter tuşuna basana kadar bekler.
            Console.WriteLine("Bulduğun sonucu belirlediğin rastgele bir sayı ile topla ve sonucu ekrana yazdıktan sonra enter tuşuna bas");
            double number = Convert.ToDouble(Console.ReadLine());//string to duoble dönüşümü yapıldı.
            Console.WriteLine("Bulduğun sonucu ikiya böl ve enter tuşuna bas");
            Console.ReadLine();//enter tuşuna basana kadar bekler.
            Console.WriteLine("Buluğun sonucu ilk sayıdan çıkar");
            Console.ReadLine();//enter tuşuna basana kadar bekler.
            string tahmin = (number/2).ToString();//double to string dönüşümü yapıldı.
            Console.WriteLine("Galiba tuttuğun sayı "+tahmin+" mi/mu");
            Console.ReadLine();//enter tuşuna basana kadar bekler.

        }
    }
}
