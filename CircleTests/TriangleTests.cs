using NUnit.Framework;
using ShapeLibrary;

namespace ShapeTests
{
    [TestFixture]
    public class TriangleTests
    {
        [TestCase(3, 4, 5, ExpectedResult = 6)]
        [TestCase(4, 4, 5, ExpectedResult = 7.806247497997997)]
        public double AreaTest(double sideA, double sideB, double sideC)
        {
            return Triangle.Factory
                 .CreateTriangleBySide(sideA, sideB, sideC)
                 .Area();
        }
        [TestCase(ExpectedResult = true)]
        public bool IsRectangularTest()
        {
           return Triangle.Factory
                .CreateTriangleBySide(3, 4, 5)
                .IsRectangular();
        }
        [TestCase(1, 1, 3, ExpectedResult = false)]
        [TestCase(3, 4, 5, ExpectedResult = true)]
        public bool IsTriangleTest(double sideA, double sideB, double sideC)
        {
            return Triangle.Factory
                      .CreateTriangleBySide(sideA, sideB, sideC)
                      .IsTriangle();
        }
    }
}
