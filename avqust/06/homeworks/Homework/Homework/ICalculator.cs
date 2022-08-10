using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    interface ICalculator
    {

        int IAddition(int a, int b);

        int ISubtraction(int a, int b);

        int IMultiplication(int a, int b);

        int IDivision(int a, int b);

        void ICalc(int enterA, int enterB, char operation);
    }
}
