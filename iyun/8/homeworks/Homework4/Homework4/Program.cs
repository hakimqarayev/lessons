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
            Homework 4:
             Aşağıdakı dəyərləri düzgün tiplərdə dəyişənlər yaradıb saxlayın:
            1: "Hava gozeldir."
             2: '%'
             3: 9999999999999999
             4: true
             5: false
             6: '0'
             7: 0
             8: 150
             9: -111111111115615
             10: 15.2M
             11: 15.2
             12: 15.2F
             13: new DateTime(2020, 12, 12)
             */

            string wh = "Hava gozeldir.";

            char ch = '%';

            ulong i = 9999999999999999;
            //double d = 9999999999999999;
            //decimal dd = 9999999999999999;
            //float f = 9999999999999999;

            bool b = true, b1 = 3 < 4;
            bool b2 = false, b3 = 13 > 10;

            char c = '0';

            byte by = 0;
            byte s = 150;

            long l = -111111111115615;

            decimal d = 15.2m;
            double dd = 15.2;
            float f = 15.2f;

            DateTime date = new DateTime(2020, 12, 12);
        }
    }
}
