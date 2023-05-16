namespace Geometry.Domain.Validation
{
    public class ShapeValidationResult
    {
        public bool IsValid => Errors.Count == 0;
        public List<string> Errors { get; private set; } = new List<string>();
    }
}
