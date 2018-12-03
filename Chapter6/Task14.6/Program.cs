using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vyvedete desetichno chislo: ");
            int n = Int32.Parse(Console.ReadLine());
            string sistema = Convert.ToString(Convert.ToInt32(n, 10), 16);
            Console.WriteLine("Rezultatyt e {0}", sistema);
        }
    }
}
