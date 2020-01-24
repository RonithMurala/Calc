using Microsoft.VisualStudio.TestTools.UnitTesting;

using Calc;
using System;

namespace CalcTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void SimpleAdditionTest()
        {
            double expected_sum = 41.5;
            Calculator obj = new Calculator(28.5,13);
            double actual_sum = obj.Add();
            Assert.AreEqual(expected_sum, actual_sum);
        }

        [TestMethod]
        public void SimpleSubtractionTest()
        {
            double expected_diff = 15.5;
            Calculator obj = new Calculator(28.5, 13);
            double actual_diff = obj.Sub();
            Assert.AreEqual(expected_diff, actual_diff);
        }

        [TestMethod]
        public void SimpleMultiplicationTest()
        {
            double expected_prod = 370.5;
            Calculator obj = new Calculator(28.5, 13);
            double actual_prod = obj.Mul();
            Assert.AreEqual(expected_prod, actual_prod);
        }

        [TestMethod]
        public void SimpleDivisionTest()
        {
            double expected_quo = 2.192;
            Calculator obj = new Calculator(28.5, 13);
            double actual_quo = obj.Div();
            Assert.AreEqual(expected_quo, actual_quo, 0.01);
        }

        [TestMethod]
        public void DividingByZeroTest()
        {
            Calculator obj = new Calculator(10, 0);
            Assert.ThrowsException<DivideByZeroException>(() => obj.Div());
        }
    }
}
