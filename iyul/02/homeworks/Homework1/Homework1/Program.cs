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
        { /*
             Homework 1:
             Main methodunda tələbənin ad, soyad, qiymət 1, qiymət 2 və qiymət 3 məlumatları alınıb,
             hamısı bir method'a ötürüləcək.
             Əlavə olaraq bir Student class'ınız olsun. Bu class'da 3 method olacaq. 
             CalcAverage, RateAverage və bir dənə də CalcAverage'in overload'ı olacaq.
             Bunun üçün Method Overloading mövzusu araşdırılmalıdır.
             CalcAverage ortalama qiyməti hesablayacaq. RateAverage isə ortalama qiymətə görə,
             tələbənin ortalamasının 45-dən yuxarı/aşağı olub-olmamasını check edəcək. 
             Əgər yuxarıdırsa keçib, aşağıdırsa kəsilib yazısını ekrana çıxardacaq. 
             */

            int point1, point2, point3, average;
            string name, surname;

            Console.WriteLine("Telebenin adini daxil edin:");
            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Telebenin soyadini daxil edin:");
            surname = Convert.ToString(Console.ReadLine());

            Console.WriteLine("1. qiymeti daxil edin:");
            point1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("2. qiymeti daxil edin:");
            point2 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("3. qiymeti daxil edin:");
            point3 = Convert.ToByte(Console.ReadLine());

            Info(name, surname, point1, point2, point3);

            Student st = new Student();
            average = st.CalcAverage(point1, point2, point3);
            Console.WriteLine("Ortalama neticeniz = "+average);
            st.RateAverage(point1, point2, point3);


            Console.ReadLine();
        }


        static void Info(string nm, string snm, int pnt1, int pnt2, int pnt3)
        {
            Console.WriteLine("Telebe melumatlari : {0} {1} {2} {3} {4} ", nm, snm, pnt1, pnt2, pnt3);
        }
    }
}
