using Xunit;
using Validators;
using System;

namespace Validators.Tests
{
    public class FileValidatorTests
    {
        private static readonly string filePath = "D:/EdgeDetection/EdgeDetection.Tests/images";
        
        [Theory]
        [InlineData("/grayscale_apple.jpeg", true)]  // Valid input jpg 
        [InlineData("/grayscale_fruit.jpg", true)]  // Valid input jpg 
        [InlineData("/grayscale_lena.png", true)]  // Valid input jpg 
        [InlineData("/Mini Assignment - Edge Detection Coding Test.pdf", false)]   // Valid input not image file extension
        [InlineData("../test/", false)]   // Invalid input (not file)
        [InlineData("abc", false)] // Invalid input
        [InlineData("1", false)] // Invalid input
        [InlineData("", false)]    // Empty input
        [InlineData(null, false)]  // Null input
        public void IsValidImageFile_ValidatesInputCorrectly(string input, bool expectedResult)
        {
            string fullPath = filePath + input;

            // Act
            bool result = FileValidator.IsValidImageFile(fullPath);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}