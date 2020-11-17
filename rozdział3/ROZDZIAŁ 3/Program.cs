using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROZDZIAŁ_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double przychod = 1000.00, koszty = 1020.50;
            double dochod = przychod - koszty;
            if ( dochod == 0)
            {
                Console.WriteLine("Mamy dochód zerowy");
            }
            else
            {
                if (dochod > 0)
                    Console.WriteLine("Mamy zysk");
                else
                    Console.WriteLine("Mamy stratę");
            }
        }
    }
}
