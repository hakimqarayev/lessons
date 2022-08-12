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
            calculator.Calc(12, 12, '*');

            Calculator2 calculator2 = new Calculator2();
            calculator2.Calc(12, 13, '+');
            Console.ReadLine();
        }
    }
}
