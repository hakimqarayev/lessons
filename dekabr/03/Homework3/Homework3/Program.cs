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
        {/*
            Homework 3:
             Bir dənə int array'ında 1-1000 arası rəqəmləriniz olsun (for ilə edin).
             1. Array'dan cüt rəqəmləri sorğu ilə götürün.
             2. Arrayda 400-dən böyük, 550-yə bərabər və ya kiçik olan, tək rəqəmləri götürün.
          */

            int[] arr = new int[1000];

            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            var query = arr.Where(a => a % 2 == 0).ToArray();

            var query2  = arr.Where(a =>
                                     a > 400 && 
                                     a <= 550 && 
                                     a % 2 == 1 )
                                     .ToArray();
        }
    }
}
