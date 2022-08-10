using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Calc(12, 12, '-');

            ICalculator Icalculator = new Calculator();
            Icalculator.ICalc(23, 2, '*');

            Console.ReadLine();
        }
    }
}
