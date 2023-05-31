using Geometry.Domain.Shapes;
using System.Collections;

namespace Geometry.UnitTests.TestData
{
    public class CalculationTestData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new()
        {
            new object[] { new Circle(5), 78.539816 },
            new object[] { new Circle(2), 12.566371 },
            new object[] { new Triangle(5, 4, 3), 6 },
            new object[] { new Triangle(1.5, 2, 1), 0.726184 },
            new object[] { new Circle(double.MaxValue - 1), -1 },
            new object[] { new Triangle(
                (double.MaxValue / 2) - 5,
                (double.MaxValue / 2) - 4,
                (double.MaxValue / 2) - 3),
                -1 }
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
