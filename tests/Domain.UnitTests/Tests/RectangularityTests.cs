using Domain.UnitTests.TestData;
using Geometry.Domain.Shapes;

namespace Domain.UnitTests.Tests
{
    public class RectangularityTests
    {

        [Theory]
        [MemberData(nameof(RectangularityTestData.TriangleData), MemberType = typeof(RectangularityTestData))]
        public void TriangleIsRectangular_ShouldReturnCorrectResult_WhenTriangleAndExpectedResultPassed(Triangle t, bool isRectangular)
        {
            Assert.Equal(isRectangular, t.IsRectangular);
        }
    }
}
