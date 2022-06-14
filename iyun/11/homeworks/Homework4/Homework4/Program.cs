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
            /*
              Homework 4: İstifadəçidən qeyd etdiyim tiplərdə dəyər alıb onları uyğun tipdə dəyişənlərə çevirəcəksiz. 
              bool, string, short, long int, char, datetime.
             
            */
            Console.WriteLine("boolean deyer daxil edin:");
            var boolType = Console.ReadLine();
            bool boolConv = Convert.ToBoolean(boolType);


            Console.WriteLine("string deyer daxil edin:");
            var stringType = Console.ReadLine();
            string stringConv = Convert.ToString(stringType);

            Console.WriteLine("short deyer daxil edin:");
            var shortType = Console.ReadLine();
            short shortConv = Convert.ToInt16(shortType);


            Console.WriteLine("long deyer daxil edin:");
            var longType = Console.ReadLine();
            long longConv = Convert.ToInt64(longType);


            Console.WriteLine("int deyer daxil edin:");
            var intType = Console.ReadLine();
            int intConv = Convert.ToInt32(intType);


            Console.WriteLine("char deyer daxil edin:");
            var charType = Console.ReadLine();
            char charConv = Convert.ToChar(charType);

            Console.WriteLine("datetime");
            var dateType = Console.ReadLine();
            DateTime dateConv = Convert.ToDateTime(dateType);

            Console.ReadLine();

        }
    }
}
