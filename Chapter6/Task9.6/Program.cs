using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1;
            int rezultat = 1;
            Console.Write("Vyvedete n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Vyvedete x: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                rezultat *= i / x;
                sum += rezultat;
            }

            Console.WriteLine("Resultat: {0}", sum);
        }
    }
}
