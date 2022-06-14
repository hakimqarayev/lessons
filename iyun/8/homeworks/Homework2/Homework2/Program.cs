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
           Homework 2:
            Bir dənə anket proqramı yığacaqsınız.İstifadəçidən onun haqqında məlumatları toplayacaqsınız.Bu məlumatlar ad, soyad, cins, doğum tarixi,
          yaşadığı ölkə, yaşadığı şəhər, boy, çəki, maaş olacaq.Siz bu məlumatları saxlamaq üçün doğru bir data type seçməlisiniz.

            İstifadəçinin daxil edəcəyi məlumatlar belə olacaq:
            Ad: Mark
            Soyad: Henry
            Cins: K və ya Q
            Doğum tarixi: 1990 - 10 - 10
            Yaşadığı ölkə: Azərbaycan
            Yaşadığı şəhər: Bakı
            Boy: 1.75
            Çəki: 26.50
            Maaş: 2500.00
            */

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Salam, zəhmət olmasa adınızı daxil edin:");
            string name = Console.ReadLine();

            Console.WriteLine(name + ", zəhmət olmasa soyadınızı da daxil et:");
            string surname = Console.ReadLine();

            Console.WriteLine(name + " " + surname + " cinsinizi daxil edin(K/Q):");
            char gender = Convert.ToChar(Console.ReadLine());


            Console.WriteLine("doğum tarixinizi daxil edin:");
            DateTime birth = Convert.ToDateTime(Console.ReadLine());
            //birth.ToString("yyyy-MM-dd"));


            Console.WriteLine("Hansı ölkədə yaşayırsınız?");
            string country = Console.ReadLine();

            Console.WriteLine("Hansı şəhərdə yaşayırsız?");
            string city = Console.ReadLine();


            Console.WriteLine("Boyunuzu daxil edin(sm ilə):");
            byte height = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Çəkinizi daxil edin:");
            float weight = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine("Maaşınızı daxil edin:");
            double salary = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Anket üçün Təşəkkür edirik " + name);
        }
    }
}
