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
        {/*

            Homework 3:
             İstifadəçidən yaşını, maaşını, boyunu, çəkisini və neçə dostu olduğunu soruşacaqsınız.Daxil etdiyi bütün dəyərləri ilk öncə int tipinə convert
             edəcəksiniz.Daha sonra int dəyişənini byte tipinə cast edəcəksiniz(explicit conversion).
             Burada istifadəçi maaşı və yaşı xaricində digər məlumatları byte'ın max dəyərindən çox yazsa heç bir xəta çıxmasın. Maaşını və ya yaşını byte
             tipinin qəbul edəcəyi maksimum dəyərdən çox yazarsa elə edin ki, proqramda xəta çıxsın.
             */

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Salam, neçə yaşınız var?");
            int age  = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Maaşınızı daxil edin:");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boyunuzu daxil edin:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Çəkinizi daxil edin:");
            int weight = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Neçə dostunuz var");
            int friends = Convert.ToInt32(Console.ReadLine());


            checked
            {
                byte byteAge = (byte)age;
                byte byteSalary = (byte)salary;

                unchecked
                {
                    byte byteHeight = (byte)height;
                    byte byteWeight = (byte)weight;
                    byte byteFriends = (byte)friends;
                }


            }

        }
    }
}
