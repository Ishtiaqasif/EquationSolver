using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathUtils.Tests
{
    [TestClass()]
    public class OperationTest
    {
        private readonly Operation _operation;

        public OperationTest()
        {
            _operation = new Operation();
        }

        [TestMethod()]
        public void AddTest()
        {
            double result = _operation.Add(2, 3);
            Assert.AreEqual(result, 5);
        }

        [TestMethod()]
        public void DivideTest()
        {
            double result = _operation.Divide(9, 3);
            Assert.AreEqual(result, 3);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            double result = _operation.Multiply(1.5, 3);
            Assert.AreEqual(result, 4.5);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            double result = _operation.Subtract(0, 3);
            Assert.AreEqual(result, -3);
        }
    }
}