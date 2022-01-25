using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        [Flags]
        public enum Week
        { 
         Monday = 0b_0000001,
         Tuesday = 0b_0000010,
         Wednesday = 0b_0000100,
         Thursday = 0b_0001000,
         Friday = 0b_0010000,
         Saturday = 0b_0100000,
         Sunday = 0b_1000000,
        }

        static void Main(string[] args)
        {
        Week ofis1 = Week.Tuesday | Week.Wednesday | Week.Thursday | Week.Friday;
        Week ofis2 = Week.Tuesday | Week.Wednesday | Week.Thursday | Week.Friday | Week.Monday | Week.Saturday | Week.Sunday;
        Console.WriteLine("Введите номер офиса");
         int nomerofisa = Convert.ToInt32(Console.ReadLine());

            if (nomerofisa == 1)
            {
                Console.WriteLine($"Рабочие дни офиса 1:  - {ofis1}");
            }
            else if (nomerofisa == 2)
            {
                Console.WriteLine($"Рабочие дни офиса 2: {ofis2}");
            }
            else
            {
                Console.WriteLine("Введите номер офиса 1 или 2");
            }
            Console.ReadKey();
        }
    }
}
