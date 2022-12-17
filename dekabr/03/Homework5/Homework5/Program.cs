using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homework 5:
              Name, Surname, Fullname property'ləri olan Person adlı bir class'ınız olsun. 
              FakeData ilə Person tipində bir listə 1000 nəfər əlavə edin.
              Əlavə edəndə Name və Surname property'lərini set edin amma fullname boş qalsın. 
              Artıq əlinizdə 1000 nəfərin Ad və Soyadı olan bir list hazır olduqdan
              sonra Linq istifadə edərək Ad və Soyad'dan Fullname'i set edin.
              */

            Database db = new Database();
            db.people.ForEach(a => a.Fullname = FakeData.NameData.GetFullName());


            foreach (var item in db.people)
            {
                Console.WriteLine($"Name: {item.Name} - Surname: {item.Surname} - Fullname: {item.Fullname}");
            }

            Console.ReadLine();
        }
    }
}
