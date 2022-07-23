using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
     class Test
    {

        public static string Name;
        public static int Age { get; set; }

        public static void Method()
        {
            //Method2(); xəta baş verəcəkk çünki Method2 non-staticdir.
        }

        public  void Method2()
        {
            Method();
        }
        static Test()
        {
            Console.WriteLine("static");
        }
        public Test()
        {
            Console.WriteLine("non-static");
        }

     
    }
}
