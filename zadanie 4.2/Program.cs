using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 10 liczb calkowitych a program wyswietli dodatnie: ");
            int[] tab1 = new int[10];
            int[] tab2 = new int[10];

            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = Convert.ToInt32(Console.ReadLine());

                if (tab1[i] > 0)
                {
                    tab2[i] = tab1[i];
                }
            }

            for (int i = 0; i < tab2.Length; i++)
            {
                if (tab2[i] > 0)
                {
                    Console.WriteLine("Liczba dodatnia to: " + tab2[i]);
                }
            }
            Console.ReadKey(););
        }
    }
}
