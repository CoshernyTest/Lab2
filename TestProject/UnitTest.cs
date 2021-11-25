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

        [TestMethod]
        public void Test2()
        {
            string input = "1 2 3";
            int expected = 123;

            int actual = Calculator.Calculate(input);
            if (actual != expected) { throw new System.Exception("TEST 2 FAILED"); }
        }

        [TestMethod]
        public void Test3()
        {
            string input = "1 2 3 + 4 5 6 =";
            int expected = 579;

            int actual = Calculator.Calculate(input);
            if (actual != expected) { throw new System.Exception("TEST 3 FAILED"); }
        }

        [TestMethod]
        public void Test4()
        {
            string input = "";
            int expected = 0;

            int actual = Calculator.Calculate(input);
            if (actual != expected) { throw new System.Exception("TEST 4 FAILED"); }
        }

        [TestMethod]
        public void Test5()
        {
            string input = "1 2 3 +";
            int expected = 123;

            int actual = Calculator.Calculate(input);
            if (actual != expected) { throw new System.Exception("TEST 5 FAILED"); }
        }

        [TestMethod]
        public void Test6()
        {
            string input = "9 / 1 0 =";
            int expected = 0;

            int actual = Calculator.Calculate(input);
            if (actual != expected) { throw new System.Exception("TEST 6 FAILED"); }
        }
    }
}