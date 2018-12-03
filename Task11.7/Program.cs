using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int nachalo = 0; 
            int kray = 0;
            bool namerenaSuma = false;

            Console.Write("Vyvedete S: ");
            int s = int.Parse(Console.ReadLine());

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
                sum = masiv[i];

                for (int j = i + 1; j < dyljina; j++)
                {
                    sum += masiv[j];
                    if (sum == s)
                    {
                        nachalo = i;
                        kray = j;
                        namerenaSuma = true;
                        break;
                    }
                }

                if (namerenaSuma) break;
            }

            if (namerenaSuma) for (int i = nachalo; i <= kray; i++) Console.Write("{0},", masiv[i]);
            else Console.WriteLine("Ne e namerena suma.");
        }
    }
}
