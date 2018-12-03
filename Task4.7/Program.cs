using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1, beststart = 1, start = 0;

            Console.Write("Vyvedete dyljina na masiva: ");
            int dyljina = int.Parse(Console.ReadLine());
            int[] masiv = new int[dyljina];

            for (int i = 0; i < masiv.Length; i++)
            {
                Console.Write("Vyvedete {0} element ", i);
                masiv[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < masiv.Length - 1; i++)
            {
                if (masiv[i] == masiv[i + 1]) beststart++;
                else beststart = 1;

                if (beststart > number )
                {
                    number = beststart;
                    start = masiv[i];
                }
            }

            for (int i = 0; i < number; i++) Console.Write("{0}, ", start);
        }
    }
}
