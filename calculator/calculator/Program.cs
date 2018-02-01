using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            System.Console.WriteLine(calc.add(2, 2));
            System.Console.WriteLine(calc.subtract(2, 2));
            System.Console.WriteLine(calc.multiply(2, 4));
            System.Console.WriteLine(calc.power(2, 4));
        }
    }

    public class Calculator
    {
        public double add(double a, double b)
        {
            return (a + b);
        }
        public double subtract(double a, double b)
        {
            return (a - b);
        }
        public double multiply(double a, double b)
        {
            return (a * b);
        }
        public double power(double x, double exp)
        {
            return (Math.Pow(x,exp));
        }

    };
}
