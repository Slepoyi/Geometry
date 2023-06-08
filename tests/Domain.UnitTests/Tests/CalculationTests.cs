using Geometry.Domain.BaseShape;
using Geometry.UnitTests.TestData;

namespace Domain.UnitTests.Tests
{
    public class CalculationsTests
    {
        private const int DigitsPrecision = 4;

        [Theory]
        [ClassData(typeof(CalculationTestData))]
        public void ShapeArea_ShouldReturnCorrectAreaRounded4_WhenFigureAndExpectedAreaPassed(Shape c, double expectedArea)
        {
            Assert.Equal(
                Math.Round(expectedArea, DigitsPrecision),
                Math.Round(c.Area, DigitsPrecision));
        }
    }
}
