using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoomework1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 1:
             5 dənə dəyişəni Implicit Conversion,
             5 dənə dəyişəni Explicit Conversion,
             5 dənə dəyişəni Helper Class Conversion vasitəsilə convert edin. Dəyişən tiplərini və dəyərlərini özünüz seçin.
             */

            // Implicit Conversion:
            // byte < short < int < long < float < double\

            int i = 4652366;
            long l = i;

            byte by = 250;
            uint u = by;

            sbyte s = -123;
            short sh = s;

            float f = 125584.5566f;
            double d = f;  // ekrana yazdiranada d-nin  ozunde saxladigi deyer floatda olan deyerden uzun alindi 

        
            


            // Explicit Conversion:

            float ff = 1344.579f;
            int aa = (int)ff;


            double dd = 44.8686;
            long ll = (long)dd;


            short ss = -32767;
            sbyte sb = (sbyte)ss;

            uint uu = 445;
            byte bb = (byte)uu;

            ulong ul  = 2455;
            ushort us = (ushort)ul;




            char ch_ = 'A';
            int a = ch_;// her characterin ASCİİ cedvelinde mueyyen bir nomresi var. bu halda o nomre ekrana cixir








        }
    }
}
