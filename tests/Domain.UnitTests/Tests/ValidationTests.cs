using Geometry.Domain.Shapes;

namespace Domain.UnitTests.Tests
{
    public class ValidationTests
    {
        [Theory]
        [InlineData(-2, false)]
        [InlineData(Math.PI, true)]
        [InlineData(1.5, true)]
        [InlineData(0, true)]
        [InlineData(double.MaxValue, true)]
        public void CircleConstructor_ShouldThrow_WhenCircleIsInvalid(double r, bool isValid)
        {
            var ex = Record.Exception(() => new Circle(r));
            var notThrown = ex == null;
            Assert.Equal(isValid, notThrown);
        }

        [Theory]
        [InlineData(100, 4, 3, false)]
        [InlineData(-2, 5, 2, false)]
        [InlineData(5, 4, 3, true)]
        [InlineData(0, 0, 0, true)]
        [InlineData((double.MaxValue / 2) - 5,
                    (double.MaxValue / 2) - 4,
                    (double.MaxValue / 2) - 3,
                    true)]
        public void TriangleConstructor_ShouldThrow_WhenTriangleIsInvalid(double a, double b, double c, bool isValid)
        {
            var ex = Record.Exception(() => new Triangle(a, b, c));
            var notThrown = ex == null;
            Assert.Equal(isValid, notThrown);
        }
    }
}