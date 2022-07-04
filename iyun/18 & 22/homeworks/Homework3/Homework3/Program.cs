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
            /* 
               Homework 3: App'ın işləmə prinsipi: İlk öncə istifadəçidən 
               "Texmin oyunu ucun en yuksek deyeri daxil edin: " yazısı ilə bir rəqəm
                         alınmalıdır.
                         Sonra 1 ilə bu rəqəm arasında random bir rəqəm generate edilməlidir və 
                         istifadəçidən generate olunan rəqəmi 
                         tapmağı istənməlidir. 
                         "1. Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin: " mesajı ilə istifadəçidən bir rəqəm soruşulur. 
                         Hər səhv daxil edilən rəqəmdə eyni şey təkrar göstərilir. 
                         Sadəcə 2. 3. 4. deyə artır cəhd sayı. İstifadəçi düzgün rəqəmi
                         tapdığı zaman "5. Cəhdinizdə düzgün rəqəmi tapdınız!" mesajı göstərilməlidir.
                         */

            Console.OutputEncoding = Encoding.Unicode;
            Random num = new Random();
            int maxValue, randomNum, a, guess;

            Console.WriteLine("Təxmin oyunu üçün ən yüksək dəyəri daxil edin: ");
            maxValue = Convert.ToInt32(Console.ReadLine());

            randomNum = num.Next(1, maxValue);

            a = 1;
            while (true)
            {
                Console.WriteLine(a+". Cəhdiniz! Zəhmət olmasa random ədədi təxmin edin:");
                guess = Convert.ToInt32(Console.ReadLine());

                if (randomNum == guess)
                {
                    Console.WriteLine(a + ". Cəhdinizdə düzgün ədədi tapdınız!");
                    break;
                }
                else
                {
                    Console.WriteLine(a + ". Cəhdiniz yanlışdır.");
                }
                a++;
            }

            Console.ReadLine();
        }
    }
}
