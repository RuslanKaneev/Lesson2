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
         Понедельник = 0b_0000001,
         Вторник = 0b_0000010,
         Среда = 0b_0000100,
         Четверг = 0b_0001000,
         Пятница = 0b_0010000,
         Суббота = 0b_0100000,
         Воскресенье = 0b_1000000,
        }

        static void Main(string[] args)
        {
          Week ofis1 = (Week)0b_0011110;
          Week ofis2 = (Week)0b_1111111;
          Console.WriteLine("Введите номер офиса");
          int nomerofisa = Convert.ToInt32(Console.ReadLine());

            if (nomerofisa == 1)
            {
                Console.WriteLine($"Рабочие дни офиса {nomerofisa}:  - {ofis1}");
            }
            else if (nomerofisa == 2)
            {
                Console.WriteLine($"Рабочие дни офиса {nomerofisa}: - {ofis2}");
            }
            else
            {
                Console.WriteLine("Введите номер офиса 1 или 2");
            }
            Console.ReadKey();
        }
    }
}
