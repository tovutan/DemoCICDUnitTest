using DotNetConsoleApp;
namespace DotNetConsoleApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_WhenGivenTwoNumbers_ReturnsCorrectSum()
        {
            var calculator = new Calculator();
            var result = calculator.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_WhenGivenNegativeNumbers_ReturnsCorrectSum()
        {
            var calculator = new Calculator();
            var result = calculator.Add(-2, -3);
            Assert.Equal(-5, result);
        }
    }
}