using System;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            double roundup = Math.Pow(x, exp);
            return Math.Round(roundup, 3);
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException();
            return dividend / divisor;
        }
    }
}