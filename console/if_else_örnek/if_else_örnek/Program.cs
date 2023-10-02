using System;

namespace if_else_örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCorrect=0;
            Console.WriteLine("Türkiyenin başkenti hangi şehirdir:");
            Console.WriteLine("a-İstanbul");
            Console.WriteLine("b-Ankara");
            string answer11 = Console.ReadLine();

            if(answer11 == "b")
            {
                numberCorrect +=1;
            }

            Console.WriteLine("En hızlı hayvan hangisidir : ");
            Console.WriteLine("a-Aslan");
            Console.WriteLine("b-Çıta");
            answer11= Console.ReadLine();

            if(answer11 == "b")
            {
                numberCorrect+=1;   
            }
            Console.WriteLine("2*2 kaç eder :");
            Console.WriteLine("a-3");
            Console.WriteLine("b-4");
            answer11= Console.ReadLine();

            if(answer11 == "b")
            {
                numberCorrect+=1;
            }
                            
            if(numberCorrect >= 2)
            {
                Console.WriteLine("Tebrikler bilgi yarışamasını kazandınız.");

            }

            else
            {
                Console.WriteLine("Üzgünüz yarışmayı kaybettiniz.");
            }
        }

    }
}
