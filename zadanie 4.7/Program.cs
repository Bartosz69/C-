using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2, y = 3; 
            int[,] tab1_2d = new int[x, y];
            int[,] tab2_2d = new int[x, y];
            int[,] tab3_2d = new int[x, y];

            Console.WriteLine("Wprowadz zmienne do pierwszej macierzy: ");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    tab1_2d[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Wprowadz zmienne do drugiej macierzy: ");

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    tab2_2d[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pierwsza macierz: ");

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("{0,2} ", tab1_2d[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Druga macierz: ");

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("{0,2} ", tab2_2d[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    tab3_2d[i, j] = tab1_2d[i, j] + tab2_2d[i, j];
                }
            }

            Console.WriteLine("Macierz wyjsciowa: ");

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("{0,2} ", tab3_2d[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
