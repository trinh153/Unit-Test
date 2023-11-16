using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTest
{
  
    [TestClass]
    public class UnitTest2
    {
        private SimpleEquation s;

        [TestMethod]
        public void TestVoSoNghiem()
        {
           s = new SimpleEquation(0,0);
           Assert.AreEqual("VSN", s.SingleEquation());
        }

        [TestMethod]
        public void TestVoNghiem()
        {
            s = new SimpleEquation(0, 5);
            Assert.AreEqual("VN", s.SingleEquation());
        }

        [TestMethod]
        public void TestNghiem()
        {
            s = new SimpleEquation(1,2);
            Assert.AreEqual("-2", s.SingleEquation());
        }
    }
}
