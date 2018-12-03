using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo1 = 0;
            int chislo2 = 0;

            Console.Write("Vyvedete dyljinata na chislata: ");
            int lenght = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Vyvedete chislo: ");
                int chislo3= Int32.Parse(Console.ReadLine());
                if (i == 0)
                {
                    chislo1 = chislo2 = chislo3;
                }
                else
                {
                    if (chislo1 > chislo3)
                    {
                        chislo1 = chislo3;
                    }
                    if (chislo2 < chislo3)
                    {
                        chislo2 = chislo3;
                    }
                }
            }
            Console.WriteLine("Nai-malko - {0}, nai-golyamo - {1}", chislo1, chislo2);
        }
    }
}
