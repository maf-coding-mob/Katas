using Xunit;

namespace StringCalculator
{
    public class StringCalculatorShould
    {
        [Fact]
        public void Returns_Expected_Sum_When_Multiple_Numbers()
        {
            var stringCalculator = new StringCalculator();
            var actual = stringCalculator.Add("1,2");
            Assert.Equal(3, actual);
        }


        [Fact]
        public void Returns_0_When_Empty()
        {
            var stringCalculator = new StringCalculator();
            var actual = stringCalculator.Add(string.Empty);
            Assert.Equal(0, actual);
        }

        [Fact]
        public void Returns_0_When_0()
        {
            var stringCalculator = new StringCalculator();
            var actual = stringCalculator.Add("0");
            Assert.Equal(0, actual);
        }

        [Fact]
        public void Returns_Expected_Sum_When_Multiple_Numbers_With_CRLF()
        {
            var stringCalculator = new StringCalculator();
            var actual = stringCalculator.Add("1\n2");
            Assert.Equal(3, actual);
        }


        [Fact]
        public void Returns_Expected_Sum_When_Multiple_Numbers_With_CR()
        {
            var stringCalculator = new StringCalculator();
            var actual = stringCalculator.Add("1\n2,3");
            Assert.Equal(6, actual);
        }

        [Fact]
        public void Returns_3_When_Use_Custom_Delimiter()
        {
            var stringCalculator = new StringCalculator();
            var actual = stringCalculator.Add("//;\n1;2");
            Assert.Equal(3, actual);
        }

    }

}

