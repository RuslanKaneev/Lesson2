using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сутки");
            int minpolz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки");
            int maxpolz = Convert.ToInt32(Console.ReadLine());
            int sredtemp = (minpolz + maxpolz) / 2;
            Console.WriteLine(sredtemp);
            Console.ReadKey();
            

        }
    }
}
