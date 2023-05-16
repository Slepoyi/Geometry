using Geometry.Domain.BaseShape;
using Geometry.Domain.Validation;
using Geometry.UnitTests.TestData;

namespace Geometry.UnitTests.Tests
{
    public class ValidationTests
    {
        [Theory]
        [ClassData(typeof(ValidationTestData))]
        public void ValidateShape_ShouldReturnCorrectValidationResult_WhenFigureAndExpectedResultPassed(Shape c, bool isValid)
        {
            var result = ShapeValidator.ValidateShape(c);
            Assert.Equal(result.IsValid, isValid);
        }
    }
}