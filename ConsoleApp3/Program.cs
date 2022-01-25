using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nazvaniekursa = "1. GEEK UNIVERSITY разработки на С# ";
            string nazvaniekursa1 = "2. Беседа с Яной Пестунович";
            string kassir = "Иванова";
            string shopname = "ООО GeekBrains";
            double summapokupki = 110000.01;
            double summapokupki1 = 00.01;
            double vsego = summapokupki + summapokupki1;
            int nomercheka = 145777;
            int kkmchislo = 180000000;
            int innchiclo = 770000000;
            int nomerchekatoday = 800;
            DateTime vremya = DateTime.Today;

            Console.WriteLine("------------------------------------");
            Console.WriteLine($"-----------{shopname}-----------");
            Console.WriteLine($"------------Чек N{nomercheka}-------------");
            Console.WriteLine($"--------------{kassir}---------------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"{nazvaniekursa}");
            Console.WriteLine($"Стоимость------------------{summapokupki}");
            Console.WriteLine($"{nazvaniekursa1} --------");
            Console.WriteLine($"Стоимость-----------------------{summapokupki1}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Всего----------------------{vsego}");
            Console.WriteLine($"ККМ{kkmchislo}------ИНН{innchiclo}------");
            Console.WriteLine($"{vremya}-----------{kassir}");
            Console.WriteLine($"Продажа--------------------------{nomerchekatoday}");
            Console.WriteLine($"Итог-----------------------{vsego}");
            Console.WriteLine("------------------------------------");
            Console.ReadKey();

        }
    }
}
