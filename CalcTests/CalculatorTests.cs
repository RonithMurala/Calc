using Microsoft.VisualStudio.TestTools.UnitTesting;

using Calc;

namespace CalcTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AdditionTest()
        {
            double expected_sum = 41.5;
            Calculator o1 = new Calculator(28.5,13);
            double actual_sum = o1.add();
            Assert.AreEqual(expected_sum, actual_sum, 0.01, "Didnt pass the unit test");
        }
    }
}
