using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13._7
{
    class Program
    {
        static void Main(string[] args)
        {

            int red = 0, kol = 0, sum = -1000;

            Console.Write("Vyvedete N: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Vyvedete M: ");
            int b = int.Parse(Console.ReadLine());

            int[,] masiv = new int[a, b];

            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                {
                    Console.Write("Masiv [{0}][{1}] = ", i, j);
                    masiv[i, j] = Int32.Parse(Console.ReadLine());

                    for (int red1 = 0; red1 < masiv.Length - 2; red1++)
                        for (int kol1 = 0; kol1 < masiv.GetLength(0) - 2; kol1++)
                        {
                            int tempSum = masiv[red, kol] + masiv[red, kol + 1] + masiv[red, kol + 2] +
                                masiv[red + 1, kol] + masiv[red + 1, kol + 1] + masiv[red + 1, kol + 2] +
                                masiv[red + 2, kol] + masiv[red + 2, kol + 1] + masiv[red + 2, kol + 2];

                            if (tempSum > sum)
                            {
                                red = red1;
                                kol = kol1;
                                sum = tempSum;
                            }
                        }

                    Console.WriteLine("Result");
                    Console.WriteLine("{0} {1} {2}", masiv[red, kol], masiv[red, kol + 1], masiv[red, kol + 2]);
                    Console.WriteLine("{0} {1} {2}", masiv[red + 1, kol], masiv[red + 1, kol + 1], masiv[red + 1, kol + 2]);
                    Console.WriteLine("{0} {1} {2}", masiv[red + 2, kol], masiv[red + 2, kol + 2], masiv[red + 2, kol + 2]);
                    Console.WriteLine("Nay-golyamata suma e {0}.", sum);
                }
                }
    }
}
