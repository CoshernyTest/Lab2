using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test1()
        {
            string input = "1 2 3 + 4 5 6";
            int expected = 456;

            int actual = Calculator.Calculate(input);
            if (actual != expected) { throw new System.Exception("TEST 1 FAILED"); }
        }
    }
}