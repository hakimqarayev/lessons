using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             (Kecen dersin 3-cu taskidir.)
             1. İstifadəçidən ay'ı rəqəm olaraq alıb switch-case'dən istifadə edərək həmin ayın adını ekrana yazdırın. 
             Məsələn 1 olsa yanvar, 5 olsa may.
             2. İstifadəçi ölkənin adını daxil edəndə paytaxtının adını ekrana yazdırın.
             10 dənə ölkə olsa kifayətdir.
             */

            //// DateTime date = Convert.ToDateTime(Console.ReadLine());


            ////if (date.Month == 1)
            //// {
            ////     Console.WriteLine(date.ToString("MMMM"));
            //// }
            //// Console.ReadLine();


            #region DateTime month name
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            int dateTimeMonthName = Convert.ToInt32(date.Month);
           
            switch (dateTimeMonthName)
            {
                case 1:
                    Console.WriteLine("yanvar");
                    break;
                case 2:
                    Console.WriteLine("fevral");
                    break;
                case 3:
                    Console.WriteLine("mart");
                    break;
                case 4:
                    Console.WriteLine("aprel");
                    break;
                case 5:
                    Console.WriteLine("may");
                    break;
                case 6:
                    Console.WriteLine("iyun");
                    break;
                case 7:
                    Console.WriteLine("iyul");
                    break;
                case 8:
                    Console.WriteLine("avqust");
                    break;
                case 9:
                    Console.WriteLine("sentyabr");
                    break;
                case 10:
                    Console.WriteLine("oktyabr");
                    break;
                case 11:
                    Console.WriteLine("noyabr");
                    break;
                case 12:
                    Console.WriteLine("dekabr");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
            Console.ReadLine();
            #endregion




            #region Countries

            Console.WriteLine("Olke adi daxil edin:");
            string countryName = Console.ReadLine();

            switch (countryName)
            {
                case "Azerbaycan":
                    Console.WriteLine("Baki");
                    break;
                case "Turkiye":
                    Console.WriteLine("Ankara");
                    break;
                case "Ispaniya":
                    Console.WriteLine("Madrid");
                    break;
                case "Italiya":
                    Console.WriteLine("Roma");
                    break;
                case "Avstriya":
                    Console.WriteLine("Vyana");
                    break;
                case "Belcika":
                    Console.WriteLine("Brussel");
                    break;
                case "Cexiya":
                    Console.WriteLine("Praqa");
                    break;
                case "Danimarka":
                    Console.WriteLine("Kopenhagen");
                    break;
                case "Hindistan":
                    Console.WriteLine("Dehli");
                    break;




                default:
                    break;
            }
            Console.ReadLine();
            #endregion
        }
    }
}
