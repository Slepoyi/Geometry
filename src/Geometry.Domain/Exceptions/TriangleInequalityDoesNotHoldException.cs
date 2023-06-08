namespace Geometry.Domain.Exceptions
{
    public class TriangleInequalityDoesNotHoldException : Exception
    {
        public TriangleInequalityDoesNotHoldException()
        {
        }

        public TriangleInequalityDoesNotHoldException(string message)
            : base(message)
        {
        }

        public TriangleInequalityDoesNotHoldException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
