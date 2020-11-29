using System;

namespace Zad
{
    class Program
    {
        static void Main(string[] args)
        {

            static double exerc(double temp)
            {

                return temp * 9 / 5 + 32;
            }

            static void exerc()
            {
                double temp;
                Console.WriteLine("Podaj temperature w celcjuszach a on zamieni ja na fahrenheita: ");
                temp = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Temperatura wynosi: " + exerc(temp) + " stopni fahrenheita");
            }

            static bool exerc2a(double a, double b, double x)
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
        }
    }
}