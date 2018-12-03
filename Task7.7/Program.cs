using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.Write("Vyvedete N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Vyvedete K (K < N): ");
            int k = int.Parse(Console.ReadLine());

            int[] masiv = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Vyvedete {0} element: ", i);
                masiv[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(masiv, (a, b) => b.CompareTo(a));
            for (int i = 0; i < k; i++) sum += masiv[i];

            Console.WriteLine("Nay-golyamata suma e {0}", sum);
        
    }
    }
}
