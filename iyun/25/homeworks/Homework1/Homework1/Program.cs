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
            /*Homework 1:
                Bir array'da rəqəmləri saxlayıb sonra bütün array'dakı rəqəmlərin toplamının ortalamasını tapacaqsınız.
                Bunun üçün öncə bütün elementlərin toplamını
                tapın sonra onu array'dakı element sayına bölün. 
                Proqram açılanda istifadəçidən Array'ın neçə elementi olacağını soruşub həmin sayda elementi olacaq
                bir array yaradacaq. Arrayı yaratdıqdan sonra bütün elementlərinin dəyərlərini istifadəçidən soruşub array'ı doldurun.
                Axırda da elementlərin toplamını və ortalama dəyərini ekrana yazdırın.Bunu həm for döngüsüylə edin həm də foreach.
                */



            #region For
            double total = 0;

            Console.WriteLine("Arrayin nece elementi olacaq?");
            byte count = Convert.ToByte(Console.ReadLine());

            int[] arr = new int[count];

            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(j + ". elementi daxil edin:");
                int a = Convert.ToInt32(Console.ReadLine());
                arr[j] = a;
                total += a;

            }
            Console.WriteLine("Toplam = " + total);
            Console.WriteLine("Ortalama = " + total / count);

            Console.ReadLine();
            #endregion







            #region Fooreach
            double total_ = 0;

            Console.WriteLine("Arrayin nece elementi olacaq?");
            byte count_ = Convert.ToByte(Console.ReadLine());

            int[] arr_ = new int[count_];

            int i = 0;
            foreach (int item in arr_)
            {

                Console.WriteLine(i + ". elementi daxil edin:");
                int b = Convert.ToInt32(Console.ReadLine());
                arr_[i] = b;
                total_ += b;
                i++;


                if (i == count_)
                    break;

            }

            Console.WriteLine("Toplam = " + total_);
            Console.WriteLine("Ortalama = " + total_ / count_);

            Console.ReadLine();
            #endregion


        }
    }
}
