using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class Student
    {
        public int CalcAverage(int a, int b, int c)
        {
            int result = (a + b + c) / 3;
            return result;
        }



        public void RateAverage(int a, int b, int c)
        {
            int x = CalcAverage(a, b, c);

            if (x > 45)
                Console.WriteLine("Telebe imtahandan kecib.");

            else
                Console.WriteLine("Telebe imtahandan kesilib.");
        }



        public double CalcAverage(double a, double b, double c, double d)
        {
            double result = (a + b + c + d) / 4;
            return result;
        }

    }
}
