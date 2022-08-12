using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Calculator2 : ICalculator
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }

        public void Calc(int enterA, int enterB, char operation)
        {
            int? total = null;

            switch (operation)
            {
                case '+':
                    total = Addition(enterA, enterB);
                    break;
                case '-':
                    total = Subtraction(enterA, enterB);
                    break;
                case '*':
                    total = Multiplication(enterA, enterB);
                    break;
                case '/':
                    total = Division(enterA, enterB);
                    break;
                default:
                    Console.WriteLine("Duzgun operation daxil edin:");
                    break;
            }
            if (total.HasValue)
                Console.WriteLine("1.eded = {0}, 2.eded = {1}, Netice = {2}", enterA, enterB, total);
        }
    }
}
