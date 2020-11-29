using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            static void zadanie5_5a(int dlug, int szer)
            {
                for (int i = 0; i < dlug; i++)
                {
                    for (int j = 0; j < szer; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            static void zadanie5_5()
            {
                Console.WriteLine("Podaj dlugosc: ");
                int dlug = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Podaj szerokosc: ");
                int szer = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                zadanie5_5a(dlug, szer);
                Console.WriteLine();
                zadanie5_5a(szer, dlug);
            }
        }
    }
}
