using System;

namespace calculatorProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var uut = new Calculator.Calculator();
            Console.WriteLine("{0,7}",uut.Add(5, 5));
            Console.WriteLine("{0,7}", uut.Add(5, 5));
        }
    }
}