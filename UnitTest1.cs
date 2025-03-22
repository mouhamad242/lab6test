using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMathApp;

namespace BasicMathTest
{
    [TestClass]
    public class UnitTest1
    {
        private BasicMath math;

        [TestInitialize]
        public void Setup()
        {
            math = new BasicMath();
        }

        [TestMethod]
        public void Test_AddMethod()
        {
            Assert.AreEqual(5, math.Add(2, 3));
        }

        [TestMethod]
        public void Test_SubtractMethod()
        {
            Assert.AreEqual(4, math.Subtract(9, 5));
        }

        [TestMethod]
        public void Test_MultiplyMethod()
        {
            Assert.AreEqual(20, math.Multiply(4, 5));
        }

        [TestMethod]
        public void Test_DivideMethod()
        {
            Assert.AreEqual(2, math.Divide(10, 5));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_DivideByZero()
        {
            math.Divide(5, 0);
        }
    }
}
