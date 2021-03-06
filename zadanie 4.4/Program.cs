﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] wyniki = new int[100];
            int[] tab = new int[100];
            int licznik = 0;

            Random rand = new Random();

            for (int i = 0; i < 100; i++)
                tab[i] = rand.Next(1, 1000);

            for (int i = 0; i < 100; i++)
                licznik = NewMethod(wyniki, tab, licznik, i);

            Console.WriteLine("W wylosowanych liczbach, było {0} liczb pierwszych ", licznik);

            for (int i = 0; i < wyniki.Length; i++)
            {
                if (wyniki[i] != 0)
                {
                    Console.Write(wyniki[i] + "  ");
                }
            }
            Console.ReadKey();
        }
        private static int NewMethod(int[] wyniki, int[] tab, int licznik, int i)
        {
            {
                bool liczba = true;
                for (int y = 2; y < Math.Sqrt(tab[i]); y++)
                {
                    Console.WriteLine("y={0}     i={1}      wartość i ={2}", y, i, tab[i]);
                    if (tab[i] % y == 0)
                    {
                        Console.WriteLine("{0} nie jest liczbą pierwszą. ", tab[i]);
                        liczba = false;
                        break;
                    }
                }
                if (liczba)
                {
                    wyniki[licznik++] = tab[i];
                };
            }
            return licznik;
        }

    }
}