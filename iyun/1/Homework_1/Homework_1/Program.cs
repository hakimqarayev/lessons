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

             Asagidaki data tiplerini arasdirin ve bir numune yazmaga calisin:
             bool+
             byte+
             char+
             decimal+
             double+
             float+
             int+
             long+
             sbyte
             short +
             */
            #region int
            int a = 37471;
            Console.WriteLine("a= " + a); /*tam edeler ucun istifade olunan data tipidir. 
                                            4 byte hecme sahibdir.
                                            */

            int b = 432;
            int c = 244;
            Console.WriteLine(b - c);

            int intMinValue = int.MinValue;//-2,147,483,648
            int intMaxValue = int.MaxValue;// 2,147,483,647
            Console.Clear();
            #endregion


            #region double
            double d = 23.4234;
            double z = 3882.398;
            double x = d / z;
            Console.WriteLine(x);/* Double kesr edeler ucun istf olunan data tipidir.  
                                    C#-da default olaraq kesr tipi sayilir.
                                     8 byte hecme sahibdir. 
                                    */

            double minValue = double.MinValue;//-1.7976931348623157E+308
            double maxValue = double.MaxValue;// 1.7976931348623157E+308
            Console.Clear();
            #endregion


            #region float
            float f = 1345;//
            float q = 12.4f; /* 4 byte yer tutur. Deyere kesr eded verildikde sonuna f yazilmalidir. 
                                  Sebeb C#-da kesr ededler default olaraq double nezerde tutulur. 
                             */
            #endregion


            #region long
            long l = 9223372075807; /* tam ededler ucun istifade edilir. 8 byte-a qeder hecme sahibdir.
                        Deyer araligi: -9,223,372,036,854,775,807 --- 9,223,372,036,854,775,807

                                   */
            #endregion


            #region short
            short s = -19344; // 2 byte hecmi var. -32768 ile 32767 araliginda deyerler ala bilir.
            #endregion


            #region char
            char ch = 'c';
            ch = '@';
            ch = '2'; // ozunde yalniz bir xarakter saxlayan data tipidir. 2 byte hecmi var.
            #endregion


            #region byte
            byte by = 200; /* 1 byte-liq yer tutur. En kicik data tiplerinden biridir.
                            0 ile 255 arasinda musbet deyerler alir. 
                         */
            #endregion
 

            #region sbyte
            sbyte sby = -126; // 1 byte hecme sahibdir. -128 ile 128 arasinda deyerlere dasiya bilir.
            #endregion


            #region bool
            bool bl = true;
            bool booln = false; /* Ozunde iki cavab saxlayan data tipidir. (false -true)
                                      Default deyeri false. 
                                  */

            string name = "Adiniz daxil edin:";
            Console.WriteLine(name);

            var n = Console.ReadLine();

            bool startsWith_H = n.StartsWith("H");
            bool endsWith_m = n.EndsWith("M");
            bool equals = n.Equals("Hakim");

            Console.WriteLine("name starts with H: "+startsWith_H);
            Console.WriteLine("name ends with M: "+endsWith_m );
            Console.WriteLine("name: "+equals);

            Console.ReadLine();
            #endregion


            #region Decimal
            decimal dc = 3322;
            decimal dcc = 4596969.5584m;
            decimal decMinValue = decimal.MinValue;
            decimal decMaxValue = decimal.MaxValue;/* 16 byte yer yer tutur. 
                                                    tam ve kesr edeler ucun istifade oluna biler.
            
                                         */
            #endregion







        }
    }
}
