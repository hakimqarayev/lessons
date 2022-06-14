using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Homework 3:
             int, bool, char, string və long tipində dəyişənlər yaradıb onlara dəyər verirsiniz. 
             Sonra elə bir dəyişən yaratmalısınız
             ki, bütün bu dəyişənləri ona dəyər olaraq mənimsədə biləsiniz.
            */

            int i = 283884;
            bool b = true;
            char c = ';';
            string s = "Hello World";
            long l = 32485858584932;

            object obj = i;
            obj = b;
            obj = c;
            obj = s;
            obj = l;  

        }
    }
}
