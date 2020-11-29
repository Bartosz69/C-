using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            static void exerc_7a(int x, int n)
            {
                int w = (2 * x + 1 + n) * n / 2;
                Console.WriteLine("Wynik: {0}", w);
            }

            static void exerc_7()
            {
                Console.WriteLine("Podaj x dla ciagu W = (x+1) + (x+2) + (x+3) +.......+ (x+n)");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj n dla W = (x+1) + (x+2) + (x+3) +.......+ (x+n)");
                int n = Convert.ToInt32(Console.ReadLine());

                exerc_7a(x, n);
            }
        }
    }
}
