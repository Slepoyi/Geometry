namespace Geometry.Domain.BaseShape
{
    /// <summary>
    /// Base class for all shapes
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Area of a shape
        /// </summary>
        /// <returns>
        /// Either area of a shape or -1 in case of overflow
        /// </returns>
        public abstract double Area { get; }
    }
}
