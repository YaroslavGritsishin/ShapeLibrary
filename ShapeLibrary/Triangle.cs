using ShapeLibrary.Interfaces;

namespace ShapeLibrary
{
    public class Triangle : IShape
    {
        /// <summary>
        /// Сторона А 
        /// </summary>
        public double SideA { get; set; }
        /// <summary>
        /// Сторона B
        /// </summary>
        public double SideB { get; set; }
        /// <summary>
        /// Сторона C
        /// </summary>
        public double SideC { get; set; }

        private Triangle() { }
        private Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        /// <summary>
        /// Свойство предоставляющее фабрику создания треугольников
        /// </summary>
        public static TriangleFactory Factory => new TriangleFactory();
        /// <summary>
        /// Расчитывает полощадь текущего треугольника
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            var sides = new List<double>() { SideA, SideB, SideC };
            double semiPerimetr = sides.Sum() / 2;
            return Math.Sqrt(sides.Aggregate(semiPerimetr, (accumulate, side)
                => accumulate * (semiPerimetr - side)));
        }
        /// <summary>
        /// Фабрика для создания треугольников
        /// </summary>
        public class TriangleFactory
        {
            public Triangle CreateTriangleBySide(double sideA, double sideB, double sideC)
                => new Triangle(sideA, sideB, sideC);
        }
        /// <summary>
        /// Проверка треугольника на наличие прямого угла
        /// </summary>
        /// <returns></returns>
        public bool IsRectangular()
        {
            var sides = new List<double>() { SideA, SideB, SideC };
            double maxSide = sides.Max();
            double squareMaxSide = Math.Pow(maxSide, 2);
            double sumOfSquares = sides.Where(item => item < maxSide)
                .Select(item => Math.Pow(item, 2))
                .Sum();
            return squareMaxSide == sumOfSquares ? true : false;
        }
        /// <summary>
        /// Проверка валидности треугольника по его сторонам
        /// </summary> 
        /// <returns></returns>
        public bool IsTriangle()
        {
            if (SideA + SideB > SideC
                & SideA + SideC > SideB
                & SideB + SideC > SideA) return true;
            else return false;
        }

    }
}
