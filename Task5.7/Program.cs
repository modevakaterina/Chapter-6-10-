using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vyvedete dyljina na masiva: ");
            int dyljina = int.Parse(Console.ReadLine());

            int[] masiv = new int[dyljina];
            int sames = 1, bestSames = 1, bestStart = 0, lastElement = 0;

            for (int i = 0; i < masiv.Length; i++)
            {
                Console.Write("Vyvedete {0} element: ", i);
                masiv[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < masiv.Length - 1; i++)
            {
                if (masiv[i] + 1 == masiv[i + 1])
                {
                    sames++;
                    if (sames > bestSames)
                    {
                        bestSames = sames;
                        lastElement = i + 1;
                        bestStart = lastElement - bestSames + 1;
                    }
                }
                else sames = 1;
            }

            for (int i = bestStart; i < bestSames + bestStart; i++) Console.Write("{0}, ", masiv[i]);
        }
    }
}
