using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz tekst w ktorym wyrazy sa oddzielone spacja a program poda ile ich jest");
            int liczba = 1; 
            string tekst;
            tekst = Console.ReadLine();

            if (tekst.Length > 0)
            {
                for (int i = 0; i < tekst.Length; i++)
                {
                    if (tekst[i] == ' ')
                    {
                        liczba++;
                    }
                }
            }
            else { liczba = 0; }

            Console.WriteLine("Liczba wyrazow wynosi: " + liczba);
        }
    }
}
