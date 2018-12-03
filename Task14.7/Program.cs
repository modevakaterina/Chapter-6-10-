using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int chisl1 = 1, chisl = 1;
            string element = "e";

            Console.Write("Vyvedete N: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Vyvedete M: ");
            int m = Int32.Parse(Console.ReadLine());

            string[,] masiv = new string[n, m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Masiv [{0}][{1}] = ", i, j);
                    masiv[i, j] = Console.ReadLine();
                }
            for (int redove = 0; redove < masiv.GetLength(0); redove++)
            {
                for (int kol = 0; kol < masiv.GetLength(1) - 1; kol++)
                {
                    if (masiv[redove, kol] == masiv[redove, kol + 1]) chisl1++;
                    else chisl1 = 1;

                    if (chisl < chisl1)
                    {
                        chisl = chisl1;
                        element = masiv[redove, kol];
                    }
                }
                chisl1 = 1;
            }

            for (int kol = 0; kol < masiv.GetLength(1); kol++)
            {
                for (int redove = 0; redove < masiv.GetLength(0) - 1; redove++)
                {
                    if (masiv[redove, kol] == masiv[redove + 1, kol]) chisl1++;
                    else chisl1 = 1;

                    if (chisl < chisl1)
                    {
                        chisl = chisl1;
                        element = masiv[redove, kol];
                    }
                }
                chisl1 = 1;
            }

            for (int i = 0; i < masiv.GetLength(0) - 1; i++)
                for (int j = 0; j < masiv.GetLength(1) - 1; j++)
                {
                    for (int redove = i, kol = j; redove < masiv.GetLength(0) - 1 && kol < masiv.GetLength(1) - 1; redove++, kol++)
                    {
                        if (masiv[redove, kol] == masiv[redove + 1, kol + 1]) chisl1++;
                        else chisl1 = 1;

                        if (chisl < chisl1)
                        {
                            chisl = chisl1;
                            element = masiv[redove, kol];
                        }
                    }
                    chisl1 = 1;
                }

            for (int i = 0; i < masiv.GetLength(0) - 1; i++)
                for (int j = 1; j < masiv.GetLength(1); j++)
                {
                    for (int redove = i, kol = j; redove < masiv.GetLength(0) - 1 && kol > 0; redove++, kol--)
                    {
                        if (masiv[redove, kol] == masiv[redove + 1, kol - 1]) chisl1++;
                        else chisl1 = 1;

                        if (chisl < chisl1)
                        {
                            chisl = chisl1;
                            element = masiv[redove, kol];
                        }
                    }
                    chisl1 = 1;
                }

            for (int i = 0; i < chisl; i++) Console.Write("{0}, ", element);
                    

        }
    }
}
