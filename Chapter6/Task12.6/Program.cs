using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vyvedete chislo: ");
            int n = int.Parse(Console.ReadLine());
            string sistema = Convert.ToString(n, 2);
            Console.WriteLine("Resultatyt e {0}", sistema);
        }
    }
}
