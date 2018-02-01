using System;

namespace ExceptionsTest
{
    internal static class ExceptionsTest
    {
        private static double SafeDivision(double x, double y)
        {
            if (y == 0) throw new DivideByZeroException();

            return x / y;
        }

        private static void Main(string[] args)
        {
            double a = 98, b = 0;
            try
            {
                var result = SafeDivision(a, b);
                Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
            }
            catch (Exception e)
            {
                Console.WriteLine("attemp to divide by zero");
                //Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("program slut");
            }
        }
    }
}