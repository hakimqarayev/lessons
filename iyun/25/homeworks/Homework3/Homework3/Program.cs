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
        {
            /*Homework 3:
                Bir array'a Random() ilə 1-100000 arası 100 ədəd rəqəm yığın.
                Sonra həmin array'dakı ən kiçik və ən böyük rəqəmləri tapın. Əlavə olaraqda bütün rəqəmlərin
                toplamını ekrana yazdırın.
                */
            int min, max, total = 0;
            Random r = new Random();

            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 1000);// arrayin elementlerini random ile set edir. 
                total += arr[i];
            }

            min = arr[0];//arrayin en kicik reqeminin 0-ci element oldugun ferz edek
            max = arr[0];//arrayin en boyuk reqeminin 0-ci element oldugun ferz edek
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])/*eger yuxarida en kicik reqemdir deye ferz etdiyimiz element, arrayin i-ci elementinden
                                boyuk olarsa ferziyyemiz yanlis oldugu ucun min deyisene arrayin i-ci elementinin deyerini set edir.
                                      */
                {
                    min = arr[i];
                }
                if (max < arr[i])/*eger yuxarida en boyuk reqemdir deye ferz etdiyimiz element, arrayin i-ci elementinden
                                kicik olarsa ferziyyemiz yanlis oldugu ucun max deyisene arrayin i-ci elementinin deyerini set edir.
                                      */
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("En kicik = " + min);
            Console.WriteLine("En boyuk = " + max);
            Console.WriteLine("Toplam = " + total);
            Console.ReadLine();

            #region 2
            Random rr = new Random();

            int[] arr_ = new int[100];
            for (int i = 0; i < arr_.Length; i++)
            {
                arr_[i] = rr.Next(1, 1000);// arrayin elementlerini random ile set edir. 
                total += arr_[i];
            }
            Console.WriteLine("En kicik = " +arr_.Min());
            Console.WriteLine("En boyuk = " +arr_.Max());
            Console.WriteLine("Toplam = " + total);

            Console.ReadLine();

            #endregion


        }
    }
}
