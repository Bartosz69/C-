using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad
{
    class Program
    {
        static void Main(string[] args)
        {

            static bool exerc(double a, double b, double x)
            {
                if (a < b)
                {
                    if (x < b && x > a)
                    {
                        return true;
                    }
                    else return false;
                }
                else
                {
                    if (x > b && x < a)
                    {
                        return true;
                    }
                    else return false;
                }

            }

            static void exerc2()
            {
                double a, b, x;
                Console.WriteLine("Podaj liczby a i b ktore beda krancami przedzialow");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj liczbe x by sprawdzic czy jest w podanym wczesniej przedziale");
                x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Czy liczba nalezy do przedzialu? " + exerc(a, b, x));
            }

        }
    }
}
