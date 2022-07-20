using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Calculate
    {
        #region ForInt
        public decimal CalculateMethod(int opp, int num1, int num2)
        {
            decimal total = 0;
            int Addition(int a, int b)
            {
                return a + b;
            }
            int Subtraction(int a, int b)
            {
                return a - b;
            }
            int Multiplication(int a, int b)
            {
                return a * b;
            }
            int Division(int a, int b)
            {
                return a / b;
            }
            int Interest(int a, int b)
            {
                return (a * b) / 100;
            }
            int InterestRate(int a, int b)
            {
                return (a / b) * 100;
            }


            switch (opp)
            {

                case 1:
                    total = Addition(num1, num2);
                    break;
                case 2:
                    total = Subtraction(num1, num2);
                    break;
                case 3:
                    total = Multiplication(num1, num2);
                    break;
                case 4:
                    total = Division(num1, num2);
                    break;
                case 5:
                    total = Interest(num1, num2);
                    break;
                case 6:
                    total = InterestRate(num1, num2);
                    break;


            }
            return total;
        }
        #endregion

        #region ForDecimal
        public decimal CalculateMethod(int opp, decimal num1, decimal num2)
        {
            decimal total = 0;
            decimal Addition(decimal a, decimal b)
            {
                return a + b;
            }
            decimal Subtraction(decimal a, decimal b)
            {
                return a - b;
            }
            decimal Multiplication(decimal a, decimal b)
            {
                return a * b;
            }
            decimal Division(decimal a, decimal b)
            {
                return a / b;
            }
            decimal Interest(decimal a, decimal b)
            {
                return (a * b) / 100;
            }
            decimal InterestRate(decimal a, decimal b)
            {
                return (a / b) * 100;
            }


            switch (opp)
            {

                case 1:
                    total = Addition(num1, num2);
                    break;
                case 2:
                    total = Subtraction(num1, num2);
                    break;
                case 3:
                    total = Multiplication(num1, num2);
                    break;
                case 4:
                    total = Division(num1, num2);
                    break;
                case 5:
                    total = Interest(num1, num2);
                    break;
                case 6:
                    total = InterestRate(num1, num2);
                    break;


            }
            return total;

        }
        #endregion

        #region ForString
        public decimal CalculateMethod(int opp, string num1, string num2)
        {
            decimal total = 0;
            decimal Addition(string a, string b)//1
            {
                total = Convert.ToDecimal(a) + Convert.ToDecimal(b);
                return total;
            }
            decimal Subtraction(string a, string b)//2
            {
                total = Convert.ToDecimal(a) - Convert.ToDecimal(b);
                return total;
            }
            decimal Multiplication(string a, string b)//3
            {
                total = Convert.ToDecimal(a) * Convert.ToDecimal(b);
                return total;
            }
            decimal Division(string a, string b)//4
            {
                total = Convert.ToDecimal(a) / Convert.ToDecimal(b);
                return total;
            }
            decimal Interest(string a, string b)//5
            {
                total= (Convert.ToDecimal(a) * Convert.ToDecimal(b))/ 100;
                return total;
            }
            decimal InterestRate(string a, string b)//6
            {
                total= ( Convert.ToDecimal(a) / Convert.ToDecimal(b) ) * 100;

                return total;
            }


            switch (opp)
            {

                case 1:
                    total = Addition(num1, num2);
                    break;
                case 2:
                    total = Subtraction(num1, num2);
                    break;
                case 3:
                    total = Multiplication(num1, num2);
                    break;
                case 4:
                    total = Division(num1, num2);
                    break;
                case 5:
                    total = Interest(num1, num2);
                    break;
                case 6:
                    total = InterestRate(num1, num2);
                    break;


            }
            return total;
        }
        #endregion

        #region String-Decimal
        public decimal CalculateMethod(int opp, string num1, decimal num2)
        {
            decimal total = 0;
            decimal Addition(string a, decimal b)//1
            {
                total = Convert.ToDecimal(a) + b;
                return total;
            }
            decimal Subtraction(string a, decimal b)//2
            {
                total = Convert.ToDecimal(a) - b;
                return total;
            }
            decimal Multiplication(string a, decimal b)//3
            {
                total = Convert.ToDecimal(a) * b;
                return total;
            }
            decimal Division(string a, decimal b)//4
            {
                total = Convert.ToDecimal(a) / b;
                return total;
            }
            decimal Interest(string a, decimal b)//5
            {
                total = (Convert.ToDecimal(a) * b) / 100;
                return total;
            }
            decimal InterestRate(string a, decimal b)//6
            {
                total = (Convert.ToDecimal(a) / b) * 100;

                return total;
            }


            switch (opp)
            {

                case 1:
                    total = Addition(num1, num2);
                    break;
                case 2:
                    total = Subtraction(num1, num2);
                    break;
                case 3:
                    total = Multiplication(num1, num2);
                    break;
                case 4:
                    total = Division(num1, num2);
                    break;
                case 5:
                    total = Interest(num1, num2);
                    break;
                case 6:
                    total = InterestRate(num1, num2);
                    break;


            }
            return total;
        }
        #endregion

        #region  Int-String
        public decimal CalculateMethod(int opp, int num1, string num2)
        {
            decimal total = 0;
            decimal Addition(int a, string b)//1
            {
                total = a +Convert.ToDecimal(b);
                return total;
            }
            decimal Subtraction(int a, string b)//2
            {
                total = a - Convert.ToDecimal(b);
                return total;
            }
            decimal Multiplication(int a, string b)//3
            {
                total = a * Convert.ToDecimal(b);
                return total;
            }
            decimal Division(int a, string b)//4
            {
                total = a / Convert.ToDecimal(b);
                return total;
            }
            decimal Interest(int a, string b)//5
            {
                total = (a * Convert.ToDecimal(b)) / 100;
                return total;
            }
            decimal InterestRate(int a, string b)//6
            {
                total = (a / Convert.ToDecimal(b)) * 100;

                return total;
            }


            switch (opp)
            {

                case 1:
                    total = Addition(num1, num2);
                    break;
                case 2:
                    total = Subtraction(num1, num2);
                    break;
                case 3:
                    total = Multiplication(num1, num2);
                    break;
                case 4:
                    total = Division(num1, num2);
                    break;
                case 5:
                    total = Interest(num1, num2);
                    break;
                case 6:
                    total = InterestRate(num1, num2);
                    break;


            }
            return total;
        }
        #endregion
    }
}
