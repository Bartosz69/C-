using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj ilosc elementow w tablicy: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] tab1 = new int[n];
            int[] tab2 = new int[n];

            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < tab1.Length; i++)
            {
                if (i + 1 < tab2.Length)
                {
                    tab2[i + 1] = tab1[i];
                }
                else
                {
                    tab2[0] = tab1[i];
                }
            }
            Console.WriteLine();
            for (int i = 0; i < tab2.Length; i++)
            {
                Console.WriteLine(tab2[i]);
            }
            Console.ReadKey();
        }
    }
}
