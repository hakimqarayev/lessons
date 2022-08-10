using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public sealed class Calculator : AbstractCalculator, ICalculator
    {
        public override int Addition(int a, int b)
        {
            return a + b;
        }

        public override int Division(int a, int b)
        {
            return a / b;
        }

        public override int Multiplication(int a, int b)
        {
            return a * b;
        }

        public override int Subtraction(int a, int b)
        {
            return a - b;
        }

        public override void Calc(int enterA, int enterB, char operation)
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

        int ICalculator.IAddition(int a, int b)
        {
            return a + b;
        }

        int ICalculator.ISubtraction(int a, int b)
        {
            return a - b;
        }

        int ICalculator.IMultiplication(int a, int b)
        {
            return a * b;
        }

        int ICalculator.IDivision(int a, int b)
        {
            return a / b;
        }

        void ICalculator.ICalc(int enterA, int enterB, char operation)
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
