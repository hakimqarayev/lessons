using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Homework 2:
                int[] numArr = { 20, 92, 100, 55, 98, 1, 18, 26, 75, 33, 12 }; 
                bu arrayın içindəki elementləri kiçikdən böyüyə sıralayın. Ancaq bunu edərkən sort və reverse
                method'larından istifadə etmək olmaz :). Alqoritmasını özünüz düşünün.
                */
            int[] numArr = { 20, 92, 100, 55, 98, 1, 18, 26, 75, 33, 12 };

            int a;

            for (int i = 0; i < numArr.Length; i++)
            {
                for (int j = 0; j < numArr.Length; j++)
                {
                    if (numArr[i] < numArr[j])
                    {
                        a = numArr[j];
                        numArr[j] = numArr[i];
                        numArr[i] = a;
                    }
                }
            }
            foreach (var item in numArr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }

    }
}

