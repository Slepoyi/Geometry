using Geometry.Domain.BaseShape;
using Geometry.Domain.Helper;

namespace Geometry.Domain.Shapes
{
    public class Circle : Shape
    {
        public double R { get; private set; }
        public Circle(double r)
        {
            if (r < 0)
                throw new ArgumentOutOfRangeException(nameof(r));

            R = r;
        }

        public override double Area
        {
            get
            {
                var area = Math.PI * R * R;
                if (area.IsNanOrInfinity())
                    return -1;
                return area;
            }
        }
    }
}
