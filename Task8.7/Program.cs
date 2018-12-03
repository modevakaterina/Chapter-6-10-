using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, m, iMin, temp;

            Console.Write("Vyvedete dyljinata na masiva: ");
            int dyljina = int.Parse(Console.ReadLine());

            int[] masiv = new int[dyljina];

            for (i = 0; i < dyljina; i++)
            {
                Console.Write("Vyvedete {0} element: ", i);
                masiv[i] = Int32.Parse(Console.ReadLine());
            }

            for (m = 0; m < dyljina - 1; m++)
            {
                iMin = m;

                for (i = m + 1; i < dyljina; i++) if (masiv[i] < masiv[iMin]) iMin = i;

                if (iMin != m)
                {
                    temp = masiv[m];
                    masiv[m] = masiv[iMin];
                    masiv[iMin] = temp;
                }
            }

            for (i = 0; i < dyljina; i++) Console.Write("{0} ", masiv[i]);
        }
    }
}
