using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;
using Calculator.Properties;

namespace CalculatorTest
{
    [TestClass]
    public class RadixTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        //khong hop le cua co so k<2, k>16
        public void TestRadix1()
        {
            int radix = 17, num = 1;
            Radix r = new Radix(num);
            r.ConvertDecimalToAnother(radix);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        //khong hop le cua number<0
        public void TestRadix2()
        {
            int num = -1;
            Radix r = new Radix(num);
        }



        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
@".\Data\Testdata3.csv","Testdata3#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        //truong hop dung
        public void TestRadix3()
        {
            int num = int.Parse(TestContext.DataRow[0].ToString());
            int radix = int.Parse(TestContext.DataRow[1].ToString());
            String expected = TestContext.DataRow[2].ToString();
            Radix r = new Radix(num);
            Assert.AreEqual(expected, r.ConvertDecimalToAnother(radix));
        }
    }
}
