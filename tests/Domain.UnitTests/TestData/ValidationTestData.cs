using Geometry.Domain.Shapes;
using System.Collections;

namespace Geometry.UnitTests.TestData
{
    public class ValidationTestData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new()
        {
            new object[] { new Circle(Math.PI), true },
            new object[] { new Circle(1.5), true },
            new object[] { new Circle(-2), false },
            new object[] { new Circle(0), false },
            new object[] { new Circle(double.MaxValue), true },
            new object[] { new Triangle(5, 4, 3), true },
            new object[] { new Triangle(1.5, 2, 1), true },
            new object[] { new Triangle(-2, 5, 2), false },
            new object[] { new Triangle(0, 1, 1), false },
            new object[] { new Triangle(100, 4, 3), false },
             new object[] { new Triangle(
                (double.MaxValue / 2) - 5,
                (double.MaxValue / 2) - 4,
                (double.MaxValue / 2) - 3),
                true }
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
