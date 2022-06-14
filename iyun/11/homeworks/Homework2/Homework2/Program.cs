using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               
             Homework 2: İstifadəçidən 3 ayrı sətirdə 3 ayrı rəqəm alın. 
             İstifadəçi 3-cü rəqəmi daxil etdikdən sonra ekrana belə bir yazı yazdırın Nəticə: 5 + 5 + 10 = 20. Bunu
                         çıxma, vurma və bölmə üçün də edin.

             */
            Console.WriteLine("1-ci eded daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2-ci eded daxil edin");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3-cu eded daxil edin");
            float c = Convert.ToSingle(Console.ReadLine());


            double result = a + b + c;
            Console.WriteLine("netice: "+ a + " + " + b + " + " + c + " = " + result );


            Console.ReadLine();
            Console.Clear();



            Console.WriteLine("1-ci eded daxil edin");
            int a2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2-ci eded daxil edin");
            double b2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3-cu eded daxil edin");
            float c2 = Convert.ToSingle(Console.ReadLine());


            double result2 = a2 - b2 - c2;
            Console.WriteLine("netice: " + a2 + " - " + b2 + " - " + c2 + " = " + result2);


            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("1-ci eded daxil edin");
            int a3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2-ci eded daxil edin");
            double b3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3-cu eded daxil edin");
            float c3  = Convert.ToSingle(Console.ReadLine());


            double result3 = a3 * b3 * c3;
            Console.WriteLine("netice: " + a3 + " * " + b3 + " * " + c3 + " = " + result3);


            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("1-ci eded daxil edin");
            int a4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2-ci eded daxil edin");
            double b4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3-cu eded daxil edin");
            float c4 = Convert.ToSingle(Console.ReadLine());


            double result4  = a4 /b4 /c4 ;
            Console.WriteLine("netice: " + a4 + " / " + b4 + " / " + c4 + " = " + result4);


            Console.ReadLine();
            Console.Clear();


        }
    }
}
