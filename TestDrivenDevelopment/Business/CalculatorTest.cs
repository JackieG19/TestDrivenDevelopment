using NUnit.Framwork;

namespace Business.Tests
{
    [TextFixture]
    public class CalculatorTest
    {
        [Test]
        public void AddNumber_ValidValues_ReturnsCorrectResult()
        {
            var sut new Calculator();
            int result = sut.AddNumber(1, 2);
            Assert.That(result, IsEqualTo(3));
        }
    }
    
    public class Calculator
    {
        public int AddNumber(int a, int b)
        {
            // return 0; // failed
            return a+ b; // passed
        }
    }
}
