using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ednakvost = true;
            char[] masiv1 = new char[5] { 'a', 'b', 'c', 'd', 'e' };
            char[] masiv2 = new char[5] { 'a', 'b', 'c', 'd', 'e' };

            if (masiv1.Length > masiv2.Length) Console.WriteLine("Vtoriyat masiv e po-rano v leksikografskata podredba ");
            else if (masiv1.Length < masiv2.Length) Console.WriteLine("Pyrviyat masiv e po-rano v leksikografskata podredba .");
            else
            {
                for (int i = 0; i < masiv1.Length; i++)
                {
                    if (masiv1[i] < masiv2[i])
                    {
                        Console.WriteLine("Pyrviyat masiv e po-rano v leksikografskata podredba.");
                        ednakvost = false;
                        break;
                    }
                    if (masiv1[i] > masiv2[i])
                    {
                        Console.WriteLine("Vtoriyat masiv e po-rano v leksikografskata podredba");
                        ednakvost = false;
                        break;
                    }
                }

                if (ednakvost)
                {
                    Console.WriteLine("Dvata masiva sa ednakvi.");
                }
            }
        }
}   }     
