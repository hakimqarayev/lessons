using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
         Homework 2:
         Istifadeciden hobbilerini sorusun ve bele bir text daxil edeceyini nezere alin:

         Menim hobbilerim uzmek ve musiqi dinlemekdir.

         Ekrani Clear edin.

         SubString method'u vasitesile, musiqi sozunu tapib ekrana cixarmaga calisin.
         */

            Console.WriteLine("Hobbilerinizi daxil edin:");
            var hobbies = Console.ReadLine();
            Console.Clear();


            string substing = hobbies.Substring(17, 5);
            Console.WriteLine(substing);


            Console.ReadLine();
        }

    }
    }

