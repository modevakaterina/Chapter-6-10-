using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vyvedete visochina : ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Vyvedete shirina: ");
            int x = int.Parse(Console.ReadLine());

            int a = 0;

            for (int i = 1; i <= y; i++)
            {
                Console.Write("{0} ", i);

                a += i;
                for (int n = 1; n < x; n++)
                {
                    a += y;
                    Console.Write("{0} ", a);
                }

                a = 0;
                Console.WriteLine();
            }
        }
        }
}
