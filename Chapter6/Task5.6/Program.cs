using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1, num3 = 0;
            int length = Int32.Parse(Console.ReadLine());
            Console.Write("Vyvedete N: ");
            Console.Write("{0},{1}," + num1,num2);

            for (int i = 2; i < length; i++)
            {
                num3 = num1 + num2;
                Console.Write(" {0},", num3);
                num1 = num2 = num3;
                
            }
        }
    }
}
