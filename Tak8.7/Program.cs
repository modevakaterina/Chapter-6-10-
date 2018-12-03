using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tak8._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int m;
            int nMin;
            int temp;

            Console.Write("Vyvedete dyljinata na masiva: ");
            int dyljina = int.Parse(Console.ReadLine());

            int[] masiv = new int[dyljina];

            for (n = 0; n< dyljina; n++)
            {
                Console.Write("Vyvedete {0} element: ", n);
                masiv[n] = int.Parse(Console.ReadLine());
            }

            for (m = 0; m < dyljina - 1; m++)
            {
                nMin = m;

                for (n = m + 1; n < dyljina; n++) if (masiv[n] < masiv[nMin]) nMin = n)

                if (nMin != m)
                {
                    temp = masiv[m];
                    masiv[m] = masiv[nMin];
                    masiv[nMin] = temp;
                }
            }
            for (i = 0; i < dyljina; i++) Console.Write("{0} ", masiv[i]);
        }
    }
}
