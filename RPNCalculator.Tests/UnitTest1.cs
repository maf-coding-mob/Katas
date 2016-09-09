using System;
using Xunit;

namespace RPNCalculator.Tests
{
    public class RPNCalculator_Should
    {
        public RPNCalculator Calculator { get; set; } = new RPNCalculator();

        [Fact]
        public void Show_Number_When_Input_Is_Number()
        {
            //Arrange
            var input = "1";
            double expected = 1;

            //Act
            var actual = Calculator.Evaluate(input);
            
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_Two_Numbers()
        {
            //Arrange
            var input = "5 3 +";
            double expected = 8;

            //Act
            var actual = Calculator.Evaluate(input);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Minus_Two_Numbers()
        {
            //Arrange
            var input = "5 3 -";
            double expected = 2;

            //Act
            var actual = Calculator.Evaluate(input);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Multiplication_Two_Numbers()
        {
            //Arrange
            var input = "6 3 *";
            double expected = 18;

            //Act
            var actual = Calculator.Evaluate(input);

            //Assert
            Assert.Equal(expected, actual);
        }

        
        
        [Fact]
        public void Divide_Two_Numbers()
        {
            //Arrange
            var input = "6 2 /";
            double expected = 3;

            //Act
            var actual = Calculator.Evaluate(input);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_By_Zero_Should_Throw()
        {
            //Arrange
            var input = "6 0 /";

            //Assert
            Assert.Throws<DivideByZeroException>(() => Calculator.Evaluate(input));
        }
    }
}
