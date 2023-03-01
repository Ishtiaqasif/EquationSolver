using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathUtils.Tests
{
    [TestClass]
    public class ArithmeticEquationSolverTest
    {
        [TestClass]
        public class SolverTest
        {
            private readonly EquationSolver _equationSolver;

            public SolverTest()
            {
                _equationSolver = new EquationSolver();
            }

            [TestMethod]
            public void TestAddition()
            {
                double result = _equationSolver.Evaluate("2 + 3");
                Assert.AreEqual(result, 5);
            }

            [TestMethod]
            public void TestSubtraction()
            {
                double result = _equationSolver.Evaluate("5 - 3");
                Assert.AreEqual(result, 2);
            }

            [TestMethod]
            public void TestMultiplication()
            {
                double result = _equationSolver.Evaluate("2 * 3");
                Assert.AreEqual(result, 6);
            }

            [TestMethod]
            public void TestDivision()
            {
                double result = _equationSolver.Evaluate("6 / 2");
                Assert.AreEqual(result, 3);
            }

            [TestMethod]
            public void TestMixedOperators()
            {
                double result = _equationSolver.Evaluate("2 + 3 * 4 - 5 / 2");
                Assert.AreEqual(result, 11.5);
            }

            //[TestMethod]
            //public void TestParentheses()
            //{
            //    double result = _equationSolver.Evaluate("(2 + 3) * 4");
            //    Assert.AreEqual(result, 20);
            //}
        }
    }
}