using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;
using Calculator.Properties;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest3
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
 @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());
            Calculation c = new Calculation(a, b);
            int actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }
    }
}
