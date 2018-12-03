using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._9
{
    class Program
    {
        static void Main()
        {
            void ReturnName(string name)
            {
                Console.WriteLine("Hello {0}", name);
            }

            void Main(string[] args)
            {
                Console.Write("Enter name: ");
                ReturnName(Console.ReadLine());
            }
        }
    }
    }
}
