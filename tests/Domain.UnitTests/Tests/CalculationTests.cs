using Geometry.Domain.BaseShape;
using Geometry.UnitTests.TestData;

namespace Geometry.UnitTests.Tests
{
    public class CalculationsTests
    {
        [Theory]
        [ClassData(typeof(CalculationTestData))]
        public void ShapeArea_ShouldReturnCorrectAreaRounded4_WhenFigureAndExpectedAreaPassed(Shape c, double expectedArea)
        {
            Assert.Equal(Math.Round(c.Area, 4), Math.Round(expectedArea, 4));
        }
    }
}
