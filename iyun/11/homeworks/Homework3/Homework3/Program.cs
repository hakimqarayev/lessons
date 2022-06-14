using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 3: İstifadəçidən 10 dənə fərqli rəqəm alıb bir dəyişəndə toplayın. 
             Bu taskı da çıxma, vurma və bölmə üçün də edin. Çıxmada və toplama əməliyyatlarında 10-cu dəyər daxil
             edildikdən sonra alınan nəticəyə 1 toplayacaq və ya çıxacaqsız. 
             Vurmada bölmədə isə, alınan nəticəni 20'ə vurun və ya bölün.

             */
            // Toplama üçün:
            {
                Console.WriteLine("1-ci ededi daxil edin:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2-ci ededi daxil edin:");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("3-cu ededi daxil edin:");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("4-cu ededi daxil edin:");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("5-ci ededi daxil edin:");
                int e = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("6-ci ededi daxil edin:");
                int f = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("7-ci ededi daxil edin:");
                int g = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("8-ci ededi daxil edin:");
                int h = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("9-ci ededi daxil edin:");
                int i = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("10-cu ededi daxil edin:");
                int j = Convert.ToInt32(Console.ReadLine());
                

                int result = a + b + c + d + e + f + g + h + i + j;
                result++;

                Console.WriteLine(result);
                Console.ReadLine();

                Console.Clear();
            }

            //Çıxma üçün:
            {
                Console.WriteLine("1-ci ededi daxil edin:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2-ci ededi daxil edin:");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("3-cu ededi daxil edin:");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("4-cu ededi daxil edin:");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("5-ci ededi daxil edin:");
                int e = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("6-ci ededi daxil edin:");
                int f = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("7-ci ededi daxil edin:");
                int g = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("8-ci ededi daxil edin:");
                int h = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("9-ci ededi daxil edin:");
                int i = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("10-cu ededi daxil edin:");
                int j = Convert.ToInt32(Console.ReadLine());
               

                int result = a - b - c - d - e - f - g - h - i - j;
                result--;
                Console.WriteLine(result);
                Console.ReadLine();

                Console.Clear();
            }


            {
                Console.WriteLine("1-ci ededi daxil edin:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2-ci ededi daxil edin:");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("3-cu ededi daxil edin:");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("4-cu ededi daxil edin:");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("5-ci ededi daxil edin:");
                int e = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("6-ci ededi daxil edin:");
                int f = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("7-ci ededi daxil edin:");
                int g = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("8-ci ededi daxil edin:");
                int h = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("9-ci ededi daxil edin:");
                int i = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("10-cu ededi daxil edin:");
                int j = Convert.ToInt32(Console.ReadLine());
                

                int result = a * b * c * d * e * f * g * h * i * j;
                result *= 20;
                Console.WriteLine(result);
                Console.ReadLine();

                Console.Clear();
            }

            {
                Console.WriteLine("1-ci ededi daxil edin:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2-ci ededi daxil edin:");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("3-cu ededi daxil edin:");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("4-cu ededi daxil edin:");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("5-ci ededi daxil edin:");
                int e = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("6-ci ededi daxil edin:");
                int f = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("7-ci ededi daxil edin:");
                int g = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("8-ci ededi daxil edin:");
                int h = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("9-ci ededi daxil edin:");
                int i = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("10-cu ededi daxil edin:");
                int j = Convert.ToInt32(Console.ReadLine());
                j++;

                int result = a / b / c / d / e / f / g / h / i / j;
                result /= 20;

                Console.WriteLine(result);
                Console.ReadLine();
            }




        }
    }
}
