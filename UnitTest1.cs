using ConsoleApp1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            var test1 = new Function();
            Assert.AreNotEqual(120, test1.Factorial(3));
        }

        [TestMethod]
        public void Test2()
        {
            var test2 = new Function();
            Assert.AreEqual(1, test2.Factorial(0));
        }

        [TestMethod]
        public void Test3()
        {
            var test3 = new Function();
            Assert.AreEqual(5040, test3.Factorial(7));
        }
    }
}