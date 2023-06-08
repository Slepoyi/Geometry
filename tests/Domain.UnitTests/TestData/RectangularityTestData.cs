using Geometry.Domain.Shapes;

namespace Domain.UnitTests.TestData
{
    public class RectangularityTestData
    {
        public static IEnumerable<object[]> TriangleData =>
            new List<object[]>
            {
                new object[] { new Triangle(1.5, 2, 1), false },
                new object[] { new Triangle(8, 4, 10), false },
                new object[] { new Triangle(5, 4, 3), true },
                new object[] { new Triangle(5, 12, 13), true },
                new object[] { new Triangle(8, 6, 10), true },
            };
    }
}
