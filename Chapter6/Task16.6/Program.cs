using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int temp, chislo;
            Console.Write("Vyvedete chislo: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            foreach (int i in arr)
            {
                chislo = rnd.Next(0, n);
                temp = arr[i];
                arr[i] = arr[chislo];
                arr[chislo] = temp;
            }


            foreach (int i in arr)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}