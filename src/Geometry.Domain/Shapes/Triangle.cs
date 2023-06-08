using Geometry.Domain.BaseShape;
using Geometry.Domain.Helper;

namespace Geometry.Domain.Shapes
{
    public class Triangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        private readonly double _p;
        public Triangle(double a, double b, double c)
        {
            if (a < 0)
                throw new ArgumentOutOfRangeException(nameof(A));

            if (b < 0)
                throw new ArgumentOutOfRangeException(nameof(B));

            if (c < 0)
                throw new ArgumentOutOfRangeException(nameof(C));

            if (a + b < c
               || a + c < b
               || b + c < a)
                throw new ArgumentOutOfRangeException(
                    "Triangle inqeuality does not hold");

            A = a;
            B = b;
            C = c;

            _p = (a + b + c) / 2;
        }

        public override double Area
        {
            get
            {
                var area = Math.Sqrt(_p * (_p - A) * (_p - B) * (_p - C));
                if (area.IsNanOrInfinity())
                    return -1;
                return area;
            }
        }

        public bool IsRectangular
            => A * A + B * B == C * C
            || A * A + C * C == B * B
            || B * B + C * C == A * A;
    }
}
