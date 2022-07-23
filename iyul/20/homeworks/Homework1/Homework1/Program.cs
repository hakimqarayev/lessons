using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Homework1.Test;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework: Static keyword'unu nəzəri cəhətdən araşdırıb presentation hazırlamalısınız.
             Optional: Praktiki nümunələr də hazırlaya bilərsiniz istəyə bağlıdır. (etməyə bilərsiniz)
             */

            // STATIC KEYWORD.

            /*
               Classda olan metodları, fieldləri propertyləri Classın objectini yaratmadan çağırmaq istəyiriksə 
               bu zaman onlari static etməliyik. RAMın static sahəsində saxlanılır. Programin sonuna qede.....
               Məsələn Main methodunun Program classının objecti yaradılmadan işləməsinin səbəbi static olmasıdır.
               Static methodun daxilinde static olmayan methodu çağıra bilmirik. Amma static olmayan methodun 
               daxilində static olanı çağıra bilirik.

               Eyni zamanda Classları da static etmək olur. Əgər ki, yaradılan Classı birdən çox yerdə instanceını yaratmadan 
               azad bir şəkildə istifadə edəcəyiksə static edə bilərik. (using static namespace.ClassName;)
               Bu halda  Classdakı bütün metodları, fieldləri propertyləri
               static etməliyik.
             */
            #region Static Class
           
            Method();
            Name = "Hakim";
            Age = 12;
            //Heç bir instance yaratmadan sadəcə Test classını static edərək içindəki static methhodu və.s istifadə edə bildikş
            #endregion


            /*
             Constructorları da static elan etmək olur. Əsas məqamlar, static constructor yalnız bir ədəd təyin oluna bilər
             Overload oluna bilməz heç bir parametr qəbul edə bilməz. Static constr. yalnız birinci dəfə classın objecti 
             işə düşür. Məsələndə aşağıdakı koddakı kimi bir neçə dəfə Test objecti yaradilsa da static constr yalnız
             bir dəfə işləyəcək.
              */
            Test t = new Test(); new Test(); new Test();


            Console.ReadLine();
        }
    }
}
