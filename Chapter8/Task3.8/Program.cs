using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            static void conversion(string value)
            {
                Console.WriteLine("{0} to decimal is {1}.",
                    value, Convert.ToInt32(value, 16));
                Console.WriteLine("{0} to decimal is {1}.\n", value,
                    Convert.ToString(Convert.ToInt32(value, 16), 2));
            }

            static void Main(string[] args)
            {
                conversion("2A3E");
                conversion("FA");
                conversion("FFFF");
                conversion("5A0E9");
            }

        }
    }
}
