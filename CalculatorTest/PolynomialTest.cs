using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class PolynomialTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod1()
        {
            int n = 2;
            List<int> a = new List<int> { 1, 2 } ;
            Polynomial p = new Polynomial (n,a);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod2()
        {
            int n = 2;
            List<int> a = new List<int> { 1, 2, 3, 4 };
            Polynomial p = new Polynomial(n, a);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int n = 2;
            List<int> a = new List<int> { 1, 2, 3 };
            double x = 1;
            int expected = 6;
            Polynomial p = new Polynomial(n, a);
            Assert.AreEqual(expected, p.Cal(x));
        }
    }
}
