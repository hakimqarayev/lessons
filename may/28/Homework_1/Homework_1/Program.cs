using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Homework 1:
             İstifadəçidən adını, soyadını, yaşadığı şəhəri soruşun və bunları dəyişənlərdə saxlayın.
             */

            #region 1st

            Console.WriteLine("Adinizi daxil edin:");
            var name_ = Console.ReadLine();

            Console.WriteLine("Soy adinizi daxil edin:");
            var surName_ = Console.ReadLine();

            Console.WriteLine("Yasadiginiz seheri daxil edin:");
            var place = Console.ReadLine();

            Console.WriteLine("Name: " + name_);
            Console.WriteLine("SurName: " + surName_);
            Console.WriteLine("PlaceOfResidence: " + place);

            Console.ReadLine();
            #endregion




            #region 2nd
            
            String name = "Adinizi daxil edin:";
            String surName = "Soyadinizi daxil edin:";
            String placeOfResidence = "Yasadiginiz seheri daxil edin:";

            Console.WriteLine(name);
            var n = Console.ReadLine();//to save the entered name

            Console.WriteLine(surName);
            var s = Console.ReadLine();//to save the entered surname

            Console.WriteLine(placeOfResidence);//to save the entered place
            var p = Console.ReadLine();

            Console.WriteLine("Name: " + n);
            Console.WriteLine("SurName: " + s);
            Console.WriteLine("PlaceOfResidence: " + p);


            Console.ReadLine();
            
            #endregion













        }
    }
}
