using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vyvedete dvoichno chislo:");
            int n = Int32.Parse(Console.ReadLine());
            string sistema = Convert.ToString(Convert.ToInt32(n, 2), 10);
            Console.WriteLine("Resultatyt e {0}", sistema);
        }
    }
}
