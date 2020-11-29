using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            static void exerc5_4b(int[] tab1, int n)
            {
                int[] tab2 = new int[tab1.Length];

                Console.WriteLine("Otrzymana tablica wynosi: (pomnzozona przez) " + n);

                for (int i = 0; i < tab1.Length; i++)
                {

                    tab1[i] *= n;
                    Console.Write(tab1[i] + ", ");
                }
                Console.WriteLine();

            }

            static int[] exerc5_4a(int[] tab1, int n)
            {
                int[] tab2 = new int[tab1.Length];

                Console.WriteLine("Otrzymana tablica wynosi: (pomnzozona przez) " + n);

                for (int i = 0; i < tab1.Length; i++)
                {
                    tab2[i] = tab1[i];
                }
                return tab2;
            }


            static void exerc5_4()
            {
                int[] tab1 = new int[] { 2, 4, 6, 8, 1, 10, 40 };
                int n;
                Console.WriteLine("Podaj liczbe przez ktora chcesz pomnozyc podana nizej tablice: ");

                for (int i = 0; i < tab1.Length; i++)
                {
                    Console.Write(tab1[i] + ", ");
                }
                Console.WriteLine();

                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Wariant B) ");

                exerc5_4b(tab1, n);

                Console.WriteLine("Wariant A) ");

                tab1 = exerc5_4a(tab1, n);
                for (int i = 0; i < tab1.Length; i++)
                {
                    Console.Write(tab1[i] + ", ");
                }
                Console.WriteLine();
            }
        }

    }
}
