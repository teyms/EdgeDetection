using System;
using System.Drawing;
using System.IO;
using Xunit;
using EdgeDetection;

namespace EdgeDetection.Tests
{

    public class PrewittEdgeDetectionTests
    {
        private static readonly string filePath = "D:/EdgeDetection/EdgeDetection.Tests/images";

        [Theory]
        [InlineData("/grayscale_apple.jpeg")]
        [InlineData("/grayscale_fruit.jpg")]
        [InlineData("/grayscale_lena.png")]
        public void ProcessEdgeDetection_ShouldProcessImage_WithoutErrors(string input)
        {
            string fullPath = filePath + input;
            Bitmap inputImage = new Bitmap(fullPath);
            PrewittEdgeDetection edgeDetection = new PrewittEdgeDetection();

            // Act
            Bitmap resultImage = edgeDetection.ProcessEdgeDetection(inputImage);

            // Assert
            Assert.NotNull(resultImage);
            Assert.Equal(inputImage.Width, resultImage.Width);
            Assert.Equal(inputImage.Height, resultImage.Height);
        }
    }



}
