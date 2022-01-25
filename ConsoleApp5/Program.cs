using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
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


            Console.WriteLine("Какой номер текущего месяца?");
            int nomermonth = Convert.ToInt32(Console.ReadLine());
            switch (nomermonth)
            {
                case 1:
                case 2:
                case 12:
                    if (sredtemp > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    else
                        Console.WriteLine($"Среднесуточная температура {sredtemp} *C"); 
                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                    Console.WriteLine($"Среднесуточная температура {sredtemp} *C");
                    break;
                default:
                    Console.WriteLine("Укажите номер текущего месяца от 1 до 12");
                    break;

            }
            Console.ReadKey();
        }
    }
}
