using System;

namespace Calculator
{
    public class Calculator
    {
        private double _Accumulator;
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;

        }

        public double Subtract(double a, double b)
        {
            Accumulator= a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {

           Accumulator = a * b;
           return Accumulator;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Math.Round(Accumulator,3);

        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException();
            Accumulator = dividend / divisor;
            return Accumulator;
        }

        public double Accumulator
        {
            get => _Accumulator;
            private set => _Accumulator = value;
        }
    }
}