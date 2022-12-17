using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        public static List<string> names = new List<string>();

        static void Main(string[] args)
        {
            /*
              Homework 4:
             Bir dənə String List'iniz olsun (names) və FakeData ilə 1000 dənə Name əlavə edin.
             Sonra həmin list'dən adı 5 simvol və ya daha uzun olan adları silin.
             Bunu etmək üçün Remove və ya RemoveAll method'larını araşdırın və sonra edin.
             */
            for (int i = 1; i <= 1000; i++)
            {
                string name;
                name = FakeData.NameData.GetFirstName().ToString();

                names.Add(name);
            }

            var delete = names.RemoveAll(n => n.Length >= 5);

            int a = 0;
            foreach (var item in names)
            {
                a++;
                Console.WriteLine($"{a}.{item}");
            }

            Console.ReadLine();

        }

    }
}
