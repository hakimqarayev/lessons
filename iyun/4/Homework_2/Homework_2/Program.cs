using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homework 2:
                        "C# variable naming convention" (C# değişken isimlendirme kuralları) mövzusunu araşdırırsınız. Araşdırmanızın
                        nəticəsi olaraq, araşdırdığınız adlandırma qaydalarından yola çıxaraq dəyişən adları yazın.
                        */


            /*
             1. C# case sensetive - boyuk kicik herfe hessas bir dildir.
            int age, int AGE ikisi de eyni ad olmagina baxmayaraq ferqli deyisenleridir.
            int age yazilishi duzgundur.
             */
            int age = 22;
            int AGE = 23;
           
            /*
             2. Deyisen adlari ya herf ya da _ isaresi ile yazilmalidir.
             _ isaresi adin istenilen yerinde yazila biler lakin önde yazilmasi private deyisen oldugunu bildirir.
             */

            /*
            C#-da bezi keywordler var ki meselen tip adlari onlari deyisen adlari kimi istifade ede bilmerik. bu zaman xeta verecek
            Shrifftler ingilis herfleri olmalidir. 
            deyisen adlari gorduyu ise uygun adlanmalidir.
            eger ad iki ve daha artiq sozden ibaretdirse, ilk herf kicik, diger sozlerin ilk herfi ise boyuk yazilmalidir Camel Case

             */

            string nameSurname= "Hakim Qarayev";
            string nameSurname_;
            int numberOfPost = 11;
            double salary;

            byte age2 = 19;
            var name = "name";
            string name_2 = "name 2";




        }
    }

            

}
           
    
        
            

             


    


