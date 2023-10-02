using System;

namespace TryCatch_mantığı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //iki sayının çarpımını bulan kodda hata ayıklama ve yönetimini yapınız.
            try
            {
                Console.WriteLine("İlk sayıyı giriniz:");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("İkinci sayıyı girinzi:");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi1 * sayi2);
            }
            //try ve catch arasına herhangi birşey yazılmaz.
            /*
            catch(FormatException)
            {
                Console.WriteLine("Hatalı giriş yaptınız.Lütfen bir sayı giriniz... ");
            }
            */
            catch(Exception ex) //Tüm hataları kapsar. ex= hata türünü kullanmak için.En sona yazılır.
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            finally 
            {
                Console.WriteLine("Burası son durak.");
            }


            
        }
    }
}
