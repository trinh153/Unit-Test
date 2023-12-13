using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class PowerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 2;
            int n = 0;
            double expected = 1;
            Assert.AreEqual(expected, Baitap.Power(x,n));
        }

        [TestMethod]
        public void TestMethod2()
        {
            double x = 3;
            int n = 2;
            double expected = 9;
            Assert.AreEqual(expected, Baitap.Power(x, n));
        }

        [TestMethod]
        public void TestMethod3()
        {
            double x = 2;
            int n = -1;
            double expected = 0.5;
            Assert.AreEqual(expected, Baitap.Power(x, n));
        }
    }
}
