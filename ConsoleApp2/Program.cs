using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой номер текущего месяца?");
            int nomermonth = Convert.ToInt32(Console.ReadLine());
            switch (nomermonth)
            {
                case 1:
                    Console.WriteLine("Текущий месяц январь");
                    break;
                case 2:
                    Console.WriteLine("Текущий месяц февраль");
                    break;
                case 3:
                    Console.WriteLine("Текущий месяц март");
                    break;
                case 4:
                    Console.WriteLine("Текущий месяц апрель");
                    break;
                case 5:
                    Console.WriteLine("Текущий месяц май");
                    break;
                case 6:
                    Console.WriteLine("Текущий месяц июнь");
                    break;
                case 7:
                    Console.WriteLine("Текущий месяц июль");
                    break;
                case 8:
                    Console.WriteLine("Текущий месяц август");
                    break;
                case 9:
                    Console.WriteLine("Текущий месяц сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Текущий месяц октябрь");
                    break;
                case 11:
                    Console.WriteLine("Текущий месяц ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Текущий месяц декабрь");
                    break;
                default:
                    Console.WriteLine("Укажите номер текущего месяца от 1 до 12");
                    break;

            }
            Console.ReadKey();
        }
    }
}
