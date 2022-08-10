using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
   public abstract class AbstractCalculator
    {
        public abstract int Addition(int a, int b);

        public abstract int Subtraction(int a, int b);

        public abstract int Multiplication(int a, int b);

        public abstract int Division(int a, int b);

        public abstract void Calc(int enterA, int enterB, char operation);

    }
}
