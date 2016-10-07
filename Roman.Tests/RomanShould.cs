using System;
using Xunit;

namespace Roman.Tests
{
    public class Roman_Should
    {

        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(10, "X")]
        [InlineData(15, "XV")]
        public void Convert_Work(int arabicNumber, string romanRepresentation)
        {
            // Arrange
            var romanConverter = new RomanConverter();

            // Act
            var actual = romanConverter.Convert(arabicNumber);

            // Assert
            Assert.Equal(romanRepresentation, actual);
        }

        [Fact]
        public void Throw_When_ArabicNumber_Is_Less_Than_1()
        {
            var romanConverter = new RomanConverter();
            
            Assert.Throws<ArgumentOutOfRangeException>(() => romanConverter.Convert(0));
        }
    }
}
