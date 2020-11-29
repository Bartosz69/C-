using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            static void exerc(ref int[,] tab1)
            {
                int i, j;
                int[,] wektor = new int[1, 2] { { 3, 2 } };
                for (i = 0; i < 1; i++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        tab1[i, j] = tab1[i, j] + wektor[i, j];
                    }
                }
            }


            static void exerc()
            {
                int[,] tab1 = new int[1, 2];
                Console.WriteLine("Podaj wspolrzedne punktu A: ");
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        tab1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("Po przesunieciu o wektor[3,2]:");
                exerc(ref tab1);

                foreach (int x in tab1)
                {
                    Console.WriteLine(x);
                }

                Console.ReadKey();
            }
        }
    }
}
