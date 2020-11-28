using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie 
{
    class Zadanie1
    {
        public static void Main(string[] args)
        {
            string string1;
            string string2;
            Console.WriteLine("Podaj pierwsze słowo");
            string1 = Console.ReadLine();
            Console.WriteLine("Podaj drugie słowo");
            string2 = Console.ReadLine();
            bool x = Metoda(string1, string2);
            if (x != true)
            {
                Console.WriteLine("jest równe");
            }
            else Console.WriteLine("nie jest są równe");



            Console.WriteLine(Obroc(string1));
            Console.WriteLine(Obroc(string2));

            Console.ReadKey();
        }

        public static bool Metoda(string s1, string s2)
        {
            if (s1.ToLower() == s2.ToLower())
            {
                return true;
            }
            else if (s1 == null && s2 == null)
            {
                return true;
            }
            else if (s1 == null && s2 != null || s1 != null && s2 == null)
            {
                return false;
            }
            else return false;
        }

        public static string Obroc(string txt)
        {
            char[] charArray = txt.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
