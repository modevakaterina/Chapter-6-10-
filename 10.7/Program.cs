using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int broyach = 0, broyach1 = 1, chislo = 0;

            Console.Write("Vyvedete dyljina na masiva: ");
            int dyljina = int.Parse(Console.ReadLine());

            int[] masiv = new int[dyljina];

            for (int i = 0; i < dyljina; i++)
            {
                Console.Write("Vyvedete {0} element: ", i);
                masiv[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(masiv);

            for (int i = 0; i < dyljina - 1; i++)
            {
                if (masiv[i] == masiv[i + 1]) broyach1++;
                else broyach1 = 1;
                if (broyach1 > broyach)
                {
                    broyach = broyach1;
                    chislo = masiv[i];
                }
            }
            Console.WriteLine("{0} otkri {1} times.", chislo, broyach);
        
    }
    }
}
