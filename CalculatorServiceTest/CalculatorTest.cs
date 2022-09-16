using CalculatorService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorServiceTest
{
    public class CalculatorTest
    {
        [Fact]
        public void sumTest()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.sum(3, 2);
            int expected = 5;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void sumNegativeTest()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.sum(-2, -3);
            int expected = -5;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void restTest()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.rest(5, 2);
            int expected = 3;

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void restNegativeTest()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.rest(-5, -2);
            int expected = -3;

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void factorialZeroTest()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.factorial(0);
            int expected = 1;

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void factorialFiveTest()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.factorial(5);
            int expected = 120;

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
