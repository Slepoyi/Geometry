using Geometry.Domain.BaseShape;

namespace Geometry.Domain.Shapes
{
    public class Circle : Shape
    {
        public double R { get; private set; }
        public Circle(double r)
        {
            R = r;
        }

        public override double Area
        {
            get
            {
                return Math.PI * R * R;
            }
        }
    }
}
