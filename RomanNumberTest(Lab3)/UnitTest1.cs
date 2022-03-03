using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumberTest_Lab3_
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 10;
            int y = 20;
            int expected = 30;
            RomanNumber actual;
            RomanNumber number1 = new RomanNumber(x);
            RomanNumber number2 = new RomanNumber(y);

            actual = number1 + number2;

            Assert.AreEqual(expected, actual);
        }
    }
}