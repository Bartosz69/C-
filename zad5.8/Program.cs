using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            static void exerc_8a(string liczba)
            {
                int suma = 0;
                for (int i = 0; i < liczba.Length; i++)
                {
                    suma += Convert.ToInt32(liczba[i].ToString());
                }
                Console.WriteLine("Suma cyfr liczby {0} wynosi {1}", liczba, suma);
            }

            static void zadanie5_8()
            {
                Console.WriteLine("Podaj liczbe calkowita wielocyfrowa");
                string liczba = Console.ReadLine();
                exerc_8a(liczba);
            }

            static int rekurencja(int n)
            {
                if ((n == 1) || (n == 2))
                    return 1;
                else
                    return rekurencja(n - 1) + rekurencja(n - 2);
            }

            static int iteracja(int n)
            {
                int a = 0;
                int b = 1;
                for (int i = 0; i < n; i++)
                {
                    b += a;
                    a = b - a;
                }
                return a;
            }
        }
    }
}
