using Domain.UnitTests.TestData;
using Geometry.Domain.Shapes;

namespace Domain.UnitTests.Tests
{
    public class RectangularityTests
    {

        [Theory]
        [ClassData(typeof(RectangularityTestData))]
        public void TriangleIsRectangular_ShouldReturnCorrectResult_WhenTriangleAndExpectedResultPassed(Triangle t, bool isRectangular)
        {
            Assert.Equal(t.IsRectangular, isRectangular);
        }
    }
}
