using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5, suma = 0;
            Console.WriteLine("Program wylosuje wartosci dla tablicy 5 x 5");
            int[,] tab2d = new int[n, n];

            Random rand = new Random();
            for (int i = 0, j = 0; i < n; i++)
            {
                tab2d[i, j] = rand.Next(1, 9);

                for (j = 0; j < n; j++)
                {
                    tab2d[i, j] = rand.Next(1, 9);
                    Console.Write("{0,1} ", tab2d[i, j]);
                }
                j = 0;
                Console.WriteLine();
            }

            for (int i = 0, j = 0; i < n; i++, j++)
            {
                suma += tab2d[i, j];
            }
            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
