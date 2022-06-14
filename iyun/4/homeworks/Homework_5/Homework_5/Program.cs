using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class Program
    {
        /*Homework 5:
             Global ve local deyisenlerin ferqlerini kodla ve comment olaraq izah edin.
            */


        public static int i = 12; //global variable. Program class-ı içində hər yerdə çağırıla, istifadə oluna bilər.
                                  /*
                                   Global dəyişənə yaradılan zaman qiymət vermək olur.(Constant Initializing) 
                                   Sonradan qiymeti metod daxilinde 
                                   verilir. 
                                   */
        double dd = 12;
        static void Main(string[] args)
        {
            int i = 5;// local variable. sadece içində olduğu block-da istifadə oluna bilər
                      /* local və global olaraq iki eyni adlı dəyişən yaradıb, local dəyişənin daxil olduğu block-da
                      o dəyişəni çağırdıqda(Məsələn Console.VVriteLine(i); ötürsək) üstünlük local dəyişəndə olur. 
                     */
            
           {
                int localVar = 134;// localVar2 ve localVar3 deyisenleri ucun global deyisendir.

                {
                    int localVar2 = 135;// localVar3 ucun global, localVar ucun ise local deyisendir.
                    {
                        int localVar3 = 463;/* local varieable. Ustde olan deyisenleri gore bilir lakin ustde olan
                                                localVar ve localVar2 deyisenleri localVar3-u gore bilmir.  
                                            */
                    }
                }
            }
        }
    }
}
