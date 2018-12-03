using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sum1;

            Console.Write("Vyvedete dyljinata na masiva: ");
            int dyljina = int.Parse(Console.ReadLine());

            int[] masiv = new int[dyljina];

            for (int i = 0; i < dyljina; i++)
            {
                Console.Write("Vyvedete {0} element: ", i);
                masiv[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < dyljina - 1; i++)
            {
                sum1 = masiv[i];

                for (int j = i + 1; j < dyljina; j++)
                {
                    sum1 += masiv[j];
                    if (sum1 > sum) sum = sum1;
                }
            }

            Console.WriteLine("Resultatyt e {0}. ", sum);
        }
    }
}
