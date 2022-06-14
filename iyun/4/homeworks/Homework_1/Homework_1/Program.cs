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
           Ev tapşırığı olaraq ilk növbədə ən az 2-3 saat internetdə "C# data types" (C# veri tipleri) mövzusunu geniş 
           bir şəkildə araşdırırsınız. Araşdıra-araşdıra da bir Console App açıb araşdırdığınız data tiplərindən nümunələr
           yazırsınız. Hər data type üçün ən az 5 fərqli nümunə yazın.
           */


            #region char 
            char ch = 'c';
           
            bool isLower = char.IsLower(ch);// kicik herf olmasini yoxlayir
            string toString = char.ToString(ch);// string-e cevirir
            bool isNUmber = char.IsNumber(ch);// reqem olmasini yoxlayir

            char sym = '#';
            bool isSymbol = char.IsSymbol(sym);//simvol olub olmamasini yoxlayir

            char num = '2';
           double getNumericValue =  char.GetNumericValue(num);/* oturulen deyisenin reqem olmasi teqdirde reqemi,
                                                                eks halda ise -1 qaytarir.
                                                               */

            #endregion

            #region Boolean 
            bool b = true;
            string trueString = bool.TrueString;

            bool opr = 3 < 4;
            Console.WriteLine(opr);
            object o = 4;
            object obj = 7;
            bool equals = bool.Equals(o,obj);//ötürülən dəyərlərin = olub olmamasını yoxlayır


            #endregion

            #region Double
            double d = 1345954.4556;

            double nan = 0.0/0.0;
            bool isNaN =  double.IsNaN(nan);
            double epsilon = double.Epsilon;// 0-dan boyuk olan en kicik musbet eded

            double nInfinity = -5.0 / 0.0;
            bool isNegativeInfinity = double.IsNegativeInfinity(nInfinity);//menfi sonsuzluq olub olmamasini yoxlayir

            double pInfinity = 5.0 / 0.0;
            bool isPositiveInfinity = double.IsPositiveInfinity(pInfinity);// musbet sonsuzluq olub olmamasini yoxlayir



            #endregion

            #region Int
            int x = 24567753;
            int a = 44495;
            bool equalsInt = int.Equals(x,a);//deyerlerin beraberliyini yoxlayir

            int z = x + a;
            z += z;
            Console.WriteLine(z);

            int oprt = z / (x * a);
            Console.WriteLine(z);


            #endregion

            #region Float

            float f = -244.56645f;
            bool inf = float.IsInfinity(f);

            float isNan = - 5 / 0f;
            bool nanF = float.IsNaN(isNan);

            float ispostf = 3 / 0.0f;
            bool pinf = float.IsPositiveInfinity(ispostf);


            #endregion

            #region Byte
            byte byt = 255;
            byte byt2 = 255;
            bool equals_ = byte.Equals(byt,byt2);

            sbyte sbyt =-120;
            bool equals_2 = sbyte.Equals(sbyt,byt);
            #endregion

            #region Long
            long l = 124567;
            long l2 = 3495;
            Console.WriteLine(l +=l);
            bool equalsLong = long.Equals(l,l2);
            
          

            #endregion

            #region Date time 
            DateTime nowTime = DateTime.Now;//local time

            DateTime date = new DateTime(2022,4,13,23,32,24,12);

            DateTime addDays = date.AddDays(12);
            DateTime addMonths = date.AddMonths(2);
            DateTime addYears = date.AddYears(2);


            Console.WriteLine(date.ToString("MM/dd/yyyy"));
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(date.ToString("MM/dd/yyyy HH:mm"));
            Console.WriteLine(date.ToString("MM/dd/yyyy hh:mm tt"));
            Console.WriteLine(date.ToString("MM/dd/yyyy H:mm"));
            Console.WriteLine(date.ToString("MM/dd/yyyy h:mm tt"));
            Console.WriteLine(date.ToString("MM/dd/yyyy HH:mm:ss"));
            Console.WriteLine(date.ToString("MMMM dd"));
            Console.WriteLine(date.ToString("yyyy MMMM"));

            Console.ReadLine();
            #endregion
        }
    }
}
