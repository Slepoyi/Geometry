using Geometry.Domain.BaseShape;
using Geometry.Domain.Shapes;

namespace Geometry.Domain.Validation
{
    public class ShapeValidator
    {
        public static ShapeValidationResult ValidateShape(Shape figure)
        {
            return figure switch
            {
                Circle c => ValidateCircle(c),
                Triangle t => ValidateTriangle(t),
                _ => UnknownShapeType()
            };
        }

        private static ShapeValidationResult ValidateCircle(Circle c)
        {
            var result = new ShapeValidationResult();

            if (c.R <= 0)
                result.Errors.Add($"Radius {c.R} of a circle should be greater than 0.");

            return result;
        }

        private static ShapeValidationResult ValidateTriangle(Triangle t)
        {
            var result = new ShapeValidationResult();

            if (t.A <= 0)
            {
                result.Errors.Add($"Side A should be greater than zero.");
            }

            if (t.B <= 0)
            {
                result.Errors.Add($"Side B should be greater than zero.");
            }

            if (t.C <= 0)
            {
                result.Errors.Add($"Side C should be greater than zero.");
            }

            if (t.A + t.B < t.C
                || t.A + t.C < t.B
                || t.B + t.C < t.A)
            {
                result.Errors.Add($"Triangle inequality does not hold.");
            }

            return result;
        }

        private static ShapeValidationResult UnknownShapeType()
        {
            var result = new ShapeValidationResult();

            result.Errors.Add($"Shape type is unknown thus cannot be validated.");

            return result;
        }
    }
}
