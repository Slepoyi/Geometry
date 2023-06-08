using Geometry.Domain.BaseShape;
using Geometry.Domain.Helper;

namespace Geometry.Domain.Shapes
{
    /// <summary>
    /// A circle
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Radius of a circle
        /// </summary>
        public double R { get; private set; }

        /// <summary>
        /// Public constructor
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when radius is less than 0
        /// </exception>
        /// <param name="r">The radius of a circle</param>
        public Circle(double r)
        {
            if (r < 0)
                throw new ArgumentOutOfRangeException(nameof(r));

            R = r;
        }

        ///<inheritdoc cref="Shape.Area"/>
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
