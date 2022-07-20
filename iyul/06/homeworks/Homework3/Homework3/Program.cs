using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        /*
             3. Local function'lar yaradaraq bir kalkulyator yaradın.
               Ümumi bir calculate methodu olmalıdır və onun içində Toplama, Çıxma, Vurma və Bölmə methodları olacaq.
               Overloadı biraz araşdırın ki, burada toplama çıxma və s. hamısı iki decimal, iki int, iki string parametr ilə işləməlidir.
               Əlavə olaraqda user string-decimal, decimal-int və int-string parametrlərini daxil etsə də işləməlidir.
               Nümunə: İki int, iki decimal dedikdə onu nəzərdə tuturam ki, (15, 15), (15.2M, 20.5M) qaydada istifadə ediləcək.
               Ancaq string-decimal dedikdə yəni parametrin biri string digəri decimal olacaq ("15", 20.2M) yada int-string üçün (20, "15") belə.
               Bölmə zamanı divide zero exeption'dan qaçının.
               Birdə Calculator'un 2 variant faiz hesablama funksiyası da olacaq. Birinci variant A parametrinin B parametr faizi neçədir?
               Yəni 100-ün 5 faizi neçədir? hesablayacaq. İkinci variant isə A parametri B parametrinin neçə faizidir? Yəni 10 (a parametri),
               100-ün (b parametrinin) neçə faizidir?
               Bu faiz hesablama methodları da yuxarıdakı digər methodlar kimi iki decimal, iki int, iki string və əlavə olaraq string-decimal,
               decimal-int və int-string parametrləri ilə işləyəcək.
            */
        public static void Main(string[] args)
        {
            decimal r1, r2, r3, r4, r5;
            Calculate cl = new Calculate();
            r1 = cl.CalculateMethod(5,12,14);
            r2 = cl.CalculateMethod(4, 23M, 7M);
            r3 = cl.CalculateMethod(1, 355, "43");
            r4 = cl.CalculateMethod(6, "32", "2");
            r5 = cl.CalculateMethod(5, "535", 26M);

            



            Console.ReadLine();
        }

    }
}
