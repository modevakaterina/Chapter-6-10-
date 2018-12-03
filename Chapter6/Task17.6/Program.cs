using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vyvedete pyrvoto chislo: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Vyvedete vtoroto chislo: ");
            int b = int.Parse(Console.ReadLine());

            while (a != 0 && b != 0)
            {
                if (a > b) a %= b;
                else b %= a;
            }

            if (a == 0)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
