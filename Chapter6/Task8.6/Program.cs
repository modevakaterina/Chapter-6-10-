using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vyvedete N: (N >=0 ) ");
            int n = int.Parse(Console.ReadLine());

            int fact1 = 2 * n;
            int fact2 = n + 1;

            for (int i = fact1 - 1; i > 0; i--)
            {
                fact1 *= i;
            }
            for (int i = fact2 - 1; i > 0; i--)
            {
                fact2 *= i;
            }
            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }

            Console.WriteLine("Result is {0}", fact1 / (fact2 * n));
        }
    }
}
