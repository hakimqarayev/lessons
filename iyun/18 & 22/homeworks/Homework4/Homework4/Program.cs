using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homework 4: İstifadəçidən bir rəqəm alın.
               While döngüsüylə istifadəçinin daxil etdiyi rəqəmdən 0-a doğru geriyə sayın.
             */

            int b = Convert.ToInt32(Console.ReadLine());

            while (true)
            {

                if (b > 0)
                {
                    b--;
                    Console.WriteLine("b=" + b);
                }
                else if (b < 0)
                {
                    b++;
                    Console.WriteLine("b=" + b);
                }
                else
                    break;

            }
            Console.ReadLine();

            //while (true)
            //{
            //    b--;
            //    Console.WriteLine("b=" + b);
            //    if (b == 0)
            //        break;
            //}
        }

    }
}
