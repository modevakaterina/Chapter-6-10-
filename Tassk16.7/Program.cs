using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassk16._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vyvedete dyljina na masiva: ");
            int dyljina = int.Parse(Console.ReadLine());

            int[] masiv = new int[dyljina];

            for (int i = 0; i < dyljina; i++)
            {
                Console.Write("Vyvedete {0} element: ", i);
                masiv[i] =int.Parse(Console.ReadLine());
            }

            Console.Write("Vyvedete tyrseno chislo: ");
            int chislo = int.Parse(Console.ReadLine());

            int index = Array.BinarySearch(masiv, chislo);

            if (index >= 0) Console.Write("Chisloto e na {0} index.", index);
            else Console.Write("Chisloto ne e namereno.");
        }
    }
}
