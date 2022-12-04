using NUnit.Framework;
using ShapeLibrary;
using ShapeLibrary.ShapeExceptions;

namespace ShapeTests
{
    [TestFixture]
    public class ShapeAreaTests
    {
        [TestCase(ExpectedResult = 6)]
        public double CalculateOfTriangleTest()
        {
            var triangle = Triangle.Factory.CreateTriangleBySide(3, 4, 5);
            return ShapeArea.Calculate(triangle);
        }
        [TestCase(ExpectedResult = 78.53981633974483)]
        public double CalculateOfCircleTest()
        {
            var circle = Circle.Factory.CreateCircleByRadius(5);
            return ShapeArea.Calculate(circle);
        }
        [TestCase(1)]
        [TestCase(null)]
        public void GetIsNotShapeExeptionTest(object shape)
        {
            Assert.Throws<IsNotShapeException>(() => ShapeArea.Calculate(shape));
        }
    }
}
