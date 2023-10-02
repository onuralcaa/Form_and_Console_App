using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string meyve, tatli;
            Console.WriteLine("En sevdiğin meyve hangisi");
            meyve = Console.ReadLine();
            Console.WriteLine("En sevdiğin tatlı ");
            tatli = Console.ReadLine(); 
            Console.Write("Dur tahmin edeyim en sevdiğin tatlı ");
            Console.WriteLine(tatli);
            Console.Write("En sevdiğin meyve ");
            Console.WriteLine(meyve);
            Console.Read();

        }
    }
}
