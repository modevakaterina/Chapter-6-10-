using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vyvedete chisloto N: (1<K<N) ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Vyvedete chisloto K: (1<K<N) ");
            int k = Int32.Parse(Console.ReadLine());

            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }

            for (int i = k - 1; i > 0; i--)
            {
                k *= i;
            }

            n /= k;
            Console.WriteLine("Rezultat:{0}", n);
        }
    }
}
