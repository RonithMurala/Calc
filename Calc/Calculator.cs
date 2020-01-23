using System;
namespace Calc
{
    public class Calculator
    {
        double a, b;
        public Calculator(double x, double y)
        {
            a = x;
            b = y;
        }
        public double add()
        {
            return a + b;
        }
        public double sub()
        {
            return a - b;
        }
        public double mul()
        {
            return a * b;
        }
        public double div()
        {
            return a / b;
        } 
        public static void Main(string[] args)
        {

            Calculator obj = new Calculator(28.5, 13);
            Console.WriteLine("Sum: {0}", obj.add());
            Console.WriteLine("Difference: {0}", obj.sub());
            Console.WriteLine("Product: {0}", obj.mul());
            Console.WriteLine("Quotient: {0}", obj.div());

       
        }
    }
}
