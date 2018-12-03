using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int broyach = 0, index, broyach1;

            Console.Write("Vyvedete dyljina na masiva: ");
            int dyljina = int.Parse(Console.ReadLine());

            int[] masiv = new int[dyljina];
            int[] resultat = new int[dyljina];

            for (int i = 0; i < dyljina; i++)
            {
                Console.Write("Vyvedete {0} element: ", i);
                masiv[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < dyljina; i++)
            {
                int[] rezultat1 = new int[dyljina];
                index = broyach1 = 1;
                rezultat1[0] = masiv[i];

                for (int j = i + 1; j < dyljina; j++)
                {
                    if (masiv[j] > rezultat1[index - 1])
                    {
                        rezultat1[index] = masiv[j];
                        index++;
                        broyach1++;
                    }
                    else if (index > 1 && masiv[j] > rezultat1[index - 2] && masiv[j] < rezultat1[index - 1]) rezultat1[index - 1] = masiv[j];
                }

                if (broyach < broyach1)
                {
                    broyach = broyach1;
                    resultat = rezultat1;
                }
            }
            for (int i = 0; i < broyach; i++) Console.Write("{0},", resultat[i]);
        }
    }
}
