using System;
using System.Reflection;
using Xunit;

namespace StringCalculator
{
    public class StringCalculatorShould
    {
        [Fact]
        public void Add_With_Empty_Return_0()
        {
            var stringCalculator = new StringCalculator();
            var actual = stringCalculator.Add("");
            Assert.Equal(0, actual);
        }

        [Fact]
        public void Return_1_When_1()
        {
            var stringCalculator = new StringCalculator();
            var actual = stringCalculator.Add("1");
            Assert.Equal(1, actual);
        }

        [Fact]
        public void Return_9_When_9()
        {
            var stringCalculator = new StringCalculator();
            var actual = stringCalculator.Add("9");
            Assert.Equal(9, actual);
        }

        [Fact]
        public void Return_3_When_1_And2()
        {
            var stringCalculator = new StringCalculator();
            var actual = stringCalculator.Add("1,2");
            Assert.Equal(3, actual);
        }
    }
}

