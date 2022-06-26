using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homework 1: İstifadəçi mənfi dəyər daxil edənə qədər,
               daxil etdiyi bütün müsbət rəqəmləri toplayıb axırda nəticəni ekrana yazın.
            */

            int result = 0;

            while (true)
            {
                Console.WriteLine("Eded daxil edin:");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a > 0)
                {
                    result += a;
                }
                else
                    break;


            }
            Console.WriteLine("Netice: " + result);
            Console.ReadLine();




        }
    }
}
