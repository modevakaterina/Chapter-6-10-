using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: (N < 20) ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int ii = i; ii <= i; ii++)
                {
                    Console.Write("{0} ", ii);
                }
                Console.WriteLine();
            }
        }
    }
}
