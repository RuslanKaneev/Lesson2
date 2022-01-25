using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int chislopolz = Convert.ToInt32(Console.ReadLine());
            int chislo = chislopolz % 2;
            
            if (chislo == 0)
            {
                Console.WriteLine($"Число четное");
            }
            else 
            {
              Console.WriteLine($"Число нечетное");
            }
            Console.ReadKey();
        }
    }
}
