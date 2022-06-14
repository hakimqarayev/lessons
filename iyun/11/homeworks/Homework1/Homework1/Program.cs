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
            /*
              
             Homework 1: İstifadəçidən 2 dənə ayrı dəyər alın(rəqəm).
             Məsələn birincidə istifadəçi 20 daxil etdi onu a dəyişənində saxlayın. İkincidə 50 daxil etdi onu da
                       b dəyişənində saxlayın. 
                       Elə edin ki, bu iki dəyişənin dəyərlərinin yerlərini dəyişdirin. 
                       Yəni a 20, b 50-dirsə elə edin ki, a olsun 50, b olsun 20.
             
             */
            #region first 

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("1-ci ədədi daxil edin(A):");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2-ci ədədi daxil edin(B):");
            int b = Convert.ToInt32(Console.ReadLine());

            int newVar = a;
            a = b;
            b = newVar;

            Console.WriteLine("A dəyişəni: " + a);
            Console.WriteLine("B dəyişəni: " + b);

            Console.ReadLine();
            #endregion



            #region second
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("1-ci ədədi daxil edin(C): ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2-ci ədədi daxil edin(D): ");
            int d = Convert.ToInt32(Console.ReadLine());

            c = c + d;//c burda daxil edilen deyerlerin toplamini dasiyir. 
            d = c - d;//burda c-nin daxil edilen deyerini d deyisenine menimsedirik. yeni istifadecinin daxil etdiyi deyeri
            c = c - d;//burda ise c yeniden deyiserek istifadecinin d ucun daxil etdiyi deyeri dasiyir  


            Console.WriteLine("C dəyişəni: " + c);
            Console.WriteLine("D dəyişəni: " + d);

            Console.ReadLine();
            #endregion


        }
    }
}
