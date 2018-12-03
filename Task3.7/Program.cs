using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ednakvost = true;

            Console.WriteLine("Vyvedete dyljinata na pyrwiq masiv: ");
            int dyljina = int.Parse(Console.ReadLine());

            int[] masiv1 = new int[dyljina];
            Console.WriteLine("Vyvedete elementite na masiva:");
            for (int i = 0; i < masiv1.Length; i++)
            {
                Console.Write("element {0}: ", i);
                masiv1[i] = int.Parse(Console.ReadLine());
            }
            

            Console.WriteLine("Vyvedete dyljinata na vtoriya masiv:");
            int dyljina2 = int.Parse(Console.ReadLine());
            int[] masiv2 = new int[dyljina2];
            if (dyljina2 != dyljina)
            {
                
                Console.WriteLine("Dyljinite na dvata masiva sa razlichni.");
                
            }
            if (dyljina2 == dyljina)
            {
                {
                    Console.WriteLine("Dyljinite na dvata masiva sa ednakvi.");
                }

                for (int i = 0; i < dyljina; i++)
                {
                    Console.WriteLine("Vyvedete element ot vtoriya masiv {0}: ", i);

                    masiv2[i] = int.Parse(Console.ReadLine());




                    if (masiv1[i] != masiv2[i])
                    {
                        Console.WriteLine("Masivite sa razlichni.");
                        ednakvost = false;
                        break;
                    }


                    if(ednakvost)
                    {

                        Console.WriteLine("Masivite sa ednakvi");
                    }

                }




        }    }
 }  }
