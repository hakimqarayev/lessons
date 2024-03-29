﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public sealed class Calculator : AbstractCalculator
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
    }
}
