using Calculator.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation c;

        [TestInitialize]
        public void SetUp()
        {
            this.c = new Calculation(10, 5);
        }

        [TestMethod]

        public void TestAddOperator()
        {
            Assert.AreEqual(c.Execute("+"), 15);
        }

        [TestMethod]
        public void TestSubOperator()
        {
            Assert.AreEqual(c.Execute("-"), 5);
        }

        [TestMethod]
        public void TestMulOperator()
        {
            Assert.AreEqual(c.Execute("*"), 50);
        }

        [TestMethod]
        public void TestDivOperator()
        {
            Assert.AreEqual(c.Execute("/"), 2);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Calculation c = new Calculation(2, 0);
            c.Execute("/");
        }
    
    }
}
