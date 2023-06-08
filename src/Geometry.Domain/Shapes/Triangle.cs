using Geometry.Domain.BaseShape;
using Geometry.Domain.Helper;

namespace Geometry.Domain.Shapes
{
    /// <summary>
    /// A triangle
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// First side of a triangle
        /// </summary>
        public double A { get; set; }
        /// <summary>
        /// Second side of a triangle
        /// </summary>
        public double B { get; set; }
        /// <summary>
        /// Third side of a triangle
        /// </summary>
        public double C { get; set; }

        /// <summary>
        /// Semiperimeter of a triangle
        /// </summary>
        /// <summary>
        /// Assigned in the constructor due to readonly modifier
        /// </summary>
        private readonly double _p;

        /// <summary>
        /// Public constructor
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when triangle inequality does not hold
        /// </exception>
        /// <param name="a">First side of a triangle</param>
        /// <param name="b">Second side of a triangle</param>
        /// <param name="c">Third side of a triangle</param>
        public Triangle(double a, double b, double c)
        {
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

        ///<inheritdoc cref="Shape.Area"/>
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

        /// <summary>
        /// Check whether a triangle is rectangular or not
        /// </summary>
        /// <returns>
        /// True if triangle is rectangular, false otherwise
        /// </returns>
        public bool IsRectangular
            => A * A + B * B == C * C
            || A * A + C * C == B * B
            || B * B + C * C == A * A;
    }
}
