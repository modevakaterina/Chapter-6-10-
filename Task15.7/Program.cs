using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15._7
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] azbuka = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.Write("Vyvedete duma: ");
            char[] duma = (Console.ReadLine()).ToCharArray();

            for (int i = 0; i < duma.Length; i++)
                for (int j = 0; j < azbuka.Length; j++)
                    if (duma[i] == azbuka[j]) Console.Write("{0} ", j);
        }
    }
}
