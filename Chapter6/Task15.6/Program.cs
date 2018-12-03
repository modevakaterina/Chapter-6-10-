using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vyvedete desetichno chislo: ");
            int n = Int32.Parse(Console.ReadLine());
            string sistema = Convert.ToString(Convert.ToInt32(n, 16), 10);
            Console.WriteLine("RRezultatyt e {0}", sistema);
        }
    }
}
