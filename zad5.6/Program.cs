using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5._6
{
    class Program
    {
        static void Main(string[] args)
        {

            static void exerc_6a(string[] tab1, int x)
            {
                Console.WriteLine("\nKonkatencja:");
                for (int i = 0; i < tab1.Length; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write(tab1[i]);
                    }
                    Console.Write(" ");
                }
            }

            static void exerc_6()
            {
                Console.WriteLine("Podaj 3 wyrazy:");
                string[] tab1 = new string[3];

                for (int i = 0; i < tab1.Length; i++)
                {
                    tab1[i] = Console.ReadLine();
                }

                Console.WriteLine("Podaj mnoznik:");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Twoje wyrazy:");
                for (int i = 0; i < tab1.Length; i++)
                {
                    Console.Write(tab1[i] + " ");
                }

                exerc_6a(tab1, x);
            }
        }
    }
}
