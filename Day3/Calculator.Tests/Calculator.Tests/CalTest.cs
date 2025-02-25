using NUnit.Framework;

namespace Calculator.Tests
{
    public class CalTest
    {
        [Test]
        public void Test_Add()
        {
     
            //Assign
            int expected = 20;
            int a = 10;
            int b = 20;
            //Act
            int actual = AddNumbers(a, b);
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        private int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
