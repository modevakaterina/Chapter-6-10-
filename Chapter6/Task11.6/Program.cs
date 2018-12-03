using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11._6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Vyvedete N: ");
            decimal n = int.Parse(Console.ReadLine());
            int nuli = 0;

            for (int i = (int)(n - 1); i > 0; i--)
                n *= i;

            Console.Write("N! e {0} i zavyrshva. ", n);

            do
            {
                n /= 10;
                nuli++;
            } while (n % 10 == 0);

            Console.WriteLine("s {0} nuli.", nuli);
        }
    }
}
