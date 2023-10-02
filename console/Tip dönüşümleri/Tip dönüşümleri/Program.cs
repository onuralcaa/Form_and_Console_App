using System;

namespace Tip_dönüşümleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberInt = 10;

            string numberString = numberInt.ToString();//int değeri String e çevrildi.
            //int numberInt2 = int.Parse(numberString);// string değeri int e çevrildi.
            int numberInt2 = Convert.ToInt32(numberString);// bir başka int e çevirme yöntemi.
            //ToInt16 = short
            //ToInt32 = int
            //ToInt64 = float
            double numberDouble = Convert.ToDouble("15");//double için
            decimal numberDecimal = Convert.ToDecimal("20");//decimal için

            Console.WriteLine(numberInt2 * 2);

        }
    }
}
