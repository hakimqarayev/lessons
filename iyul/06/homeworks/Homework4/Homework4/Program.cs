using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {             /*
               4. Bir dənə kiçik console app yazın. Bu app sizdən sinif adı soruşacaq. Məsələn 1A, 1B və s. daxil ediləcək. 
               Sonra sinif rəhbərinin adı soruşulacaq. Axırda isə, 10 tələbə adı soruşulacaq. 
               Bu tələbələrin adlarını array'dan istifadə etmədən 10 ayrı string dəyişəndə
                 saxlayın student1, student2, student3... və sonra sinif adı, müəllim adı, tələbələrin 
                 adlarını göndərə biləcəyiniz bir method yazın.
                 Method cəmi 3 parametr qəbul edə bilər. 3-dən artıq parametr istifadə etmək haqqınız yoxdur.
                 Axırda sinif haqqında məlumat yazısı və onun altında sinif adı, sinif rəhbərinin adı və tələbə adları alt-alta yazılsın.
                 Tələbə adlarını da collection və ya list
                 şəklində göndərmək haqqınız yoxdur. İp ucu verim dərsdə keçmişdik.
             */
        static void ShowInfo(string classnm, string teachernm, params string[] students)
        {

            Console.WriteLine("Sinfin adi: {0}\n" +
                              "Muellimin adi: {1}\n" +
                              "Telebeler: {2}", classnm, teachernm, string.Join("\n", students));
        }

      
        static void Main(string[] args)
        {
            string className, teacherName, student1, student2,
                student3, student4, student5, student6, student7, student8,
                student9, student10;

            Console.WriteLine("Sinif adini daxil edin: ");
            className = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Sinif rehberinin adini daxil edin: ");
            teacherName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("1. Telebenin adini daxil edin:");
            student1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("2. Telebenin adini daxil edin:");
            student2 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("3. Telebenin adini daxil edin:");
            student3 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("4. Telebenin adini daxil edin:");
            student4 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("5. Telebenin adini daxil edin:");
            student5 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("6. Telebenin adini daxil edin:");
            student6 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("7. Telebenin adini daxil edin:");

            student7 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("8. Telebenin adini daxil edin:");
            student8 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("9. Telebenin adini daxil edin:");
            student9 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("10. Telebenin adini daxil edin:");
            student10 = Convert.ToString(Console.ReadLine());

            ShowInfo(className, teacherName, student1, student2, student3, student4, student5,
                student6, student7, student8, student9, student10);



            Console.ReadLine();
        }
    }
}
