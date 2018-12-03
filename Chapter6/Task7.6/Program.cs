using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vyvedete N: (1<K<N) ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Vyvedete K: (1<K<N) ");
            int k = Int32.Parse(Console.ReadLine());
            int rezultat = n - k;

            for (int i = n - 1; i > 0; i--) n *= i;
            for (int i = k - 1; i > 0; i--) k *= i;
            for (int i = rezultat - 1; i > 0; i--) rezultat *= i;

            Console.WriteLine("Resultatyt e {0}", n * k / rezultat);
        }
    }
}
