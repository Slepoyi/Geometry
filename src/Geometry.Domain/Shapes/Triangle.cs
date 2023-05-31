using Geometry.Domain.BaseShape;
using Geometry.Domain.Helper;

namespace Geometry.Domain.Shapes
{
    public class Triangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double Area
        {
            get
            {
                var p = (A + B + C) / 2;
                var area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
                if (area.IsNanOrInfinity())
                    return -1;
                return area;
            }
        }

        public bool IsRectangular
        {
            get
            {
                return A * A + B * B == C * C
                    || A * A + C * C == B * B
                    || B * B + C * C == A * A;
            }
        }
    }
}
