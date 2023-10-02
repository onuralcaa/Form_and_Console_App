using System;

namespace Karar_mekanizması_manav_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hangi meyveyi almak istersiniz : "); ;
                string meyve = Console.ReadLine();
                Console.WriteLine("Kaç adet alacaksınız : ");
                int number = Convert.ToInt32(Console.ReadLine());
                int totalPrice = 0;

                 switch(meyve)
                {
                    case "armut":
                        totalPrice = number * 2;
                        break;

                    case "elma":
                        totalPrice = number * 3;
                        break;

                    case "ananas":
                        totalPrice = number * 5;
                        break;

                    default: 
                        totalPrice = number * 6;
                        break;
                }
                if(number >= 3)
                {
                    Console.WriteLine("Toplam fiyat "+totalPrice + " lira");
                }

                else
                {
                    Console.WriteLine("Toplam fiyat "+ (totalPrice+3) + " lira");//salladım tuttu.
                }


                
            }
            catch (Exception)
            {
                Console.WriteLine("lütfen sizden istenilen türden bilgiler giriniz.");
            }
        
        }
    }
}
