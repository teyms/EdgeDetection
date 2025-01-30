using Xunit;
using Validators;
using System;

namespace Validators.Tests
{
    public class NumberValidatorTests
    {
        [Theory]
        [InlineData("10", 1, 100, true)]  // Valid input within range
        [InlineData("1", 1, 100, true)]   // Valid input at lower bound
        [InlineData("100", 1, 100, true)] // Valid input at upper bound
        [InlineData("0", 1, 100, false)]  // Valid input below range
        [InlineData("101", 1, 100, false)] // Valid input above range
        [InlineData("abc", 1, 100, false)] // Invalid input (non-integer)
        [InlineData("", 1, 100, false)]    // Empty input
        [InlineData(null, 1, 100, false)]  // Null input
        public void IsValidInputInteger_ValidatesInputCorrectly(string input, int min, int max, bool expectedResult)
        {
            // Act
            bool result = NumberValidator.IsValidInputInteger(input, min, max);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}