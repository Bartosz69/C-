using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj liczbe elementow tablicy: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Podaj {0} pierwsza wartosc: ", i + 1);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Podane liczby to:");

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
            Console.ReadKey();
        }
    }
}
