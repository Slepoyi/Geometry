namespace Geometry.Domain.Helper
{
    public static class DoubleExtensions
    {
        public static bool IsNanOrInfinity(this double value)
        {
            return double.IsInfinity(value) || double.IsNaN(value);
        }
    }
}
