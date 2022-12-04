using NUnit.Framework;
using ShapeLibrary;
using ShapeLibrary.ShapeExceptions;

namespace ShapeTests
{
    [TestFixture]
    public class CircleTests
    {
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(null)]
        public void GetValueEqualsOrLessZeroExceptionTest(double value)
        {
            Assert.Throws<ValueEqualsOrLessZeroException>(
                () => Circle.Factory.CreateCircleByRadius(value));
        }

        [TestCase(5,ExpectedResult = 78.53981633974483)]
        public double AreaTest(double radius)
        {
           return Circle.Factory.CreateCircleByRadius(radius).Area();   
        }
    }
}