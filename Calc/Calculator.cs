using System;
namespace Calc
{
    public class Calculator
    {
        double a, b;

        /// <summary>
        /// Calculator Constructor
        /// </summary>
        /// <remarks>
        /// <para>To initialize the instance variable values</para>
        /// </remarks>
        /// <param name="x">First Double Number</param>
        /// <param name="y">Second Double Number</param>
        /// <example>
        /// <code>
        /// Calculator obj = new Calculator(10.5,12.5);
        /// </code>
        /// </example>
        public Calculator(double x, double y)
        {
            a = x;
            b = y;
        }

        /// <summary>
        /// Addition Method
        /// </summary>
        /// <remarks>
        /// <para>To add two numbers</para>
        /// </remarks>
        /// <param name="x">First Double Number</param>
        /// <param name="y">Second Double Number</param>
        /// <example>
        /// <code>
        /// Calculator obj = new Calculator(10.5,12.5);
        /// Console.WriteLine(obj.add());
        /// </code>
        /// </example>
        /// <return>Sum of two double numbers</return>
        public double Add()
        {
            return a + b;
        }

        /// <summary>
        /// Subtraction Method
        /// </summary>
        /// <remarks>
        /// <para>To subtract two numbers</para>
        /// </remarks>
        /// <param name="x">First Double Number</param>
        /// <param name="y">Second Double Number</param>
        /// <example>
        /// <code>
        /// Calculator obj = new Calculator(10.5,12.5);
        /// Console.WriteLine(obj.sub());
        /// </code>
        /// </example>
        /// <return>Difference of two double numbers</return>
        public double Sub()
        {
            return a - b;
        }

        /// <summary>
        /// Multiplication Method
        /// </summary>
        /// <remarks>
        /// <para>To multiply two numbers</para>
        /// </remarks>
        /// <param name="x">First Double Number</param>
        /// <param name="y">Second Double Number</param>
        /// <example>
        /// <code>
        /// Calculator obj = new Calculator(10.5,12.5);
        /// Console.WriteLine(obj.mul());
        /// </code>
        /// </example>
        /// <return>Product of two double numbers</return>
        public double Mul()
        {
            return a * b;
        }

        /// <summary>
        /// Division Method
        /// </summary>
        /// <remarks>
        /// <para>To divide two numbers</para>
        /// </remarks>
        /// <param name="x">First Double Number</param>
        /// <param name="y">Second Double Number</param>
        /// <example>
        /// <code>
        /// Calculator obj = new Calculator(10.5,12.5);
        /// Console.WriteLine(obj.div());
        /// </code>
        /// </example>
        /// <return>Quotient of two double numbers</return>
        public double Div()
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        } 


        public static void Main(string[] args)
        {

            Calculator obj = new Calculator(28.5, 13);
            Console.WriteLine("Sum: {0}", obj.Add());
            Console.WriteLine("Difference: {0}", obj.Sub());
            Console.WriteLine("Product: {0}", obj.Mul());
            Console.WriteLine("Quotient: {0}", obj.Div());

       
        }
    }
}
