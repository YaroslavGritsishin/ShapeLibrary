using ShapeLibrary.Interfaces;
using ShapeLibrary.ShapeExceptions;

namespace ShapeLibrary
{
    public class Circle : IShape
    {
        #region Systems
        private double _radius;
        private double _diametr;
        #endregion
        /// <summary>
        /// Значение радиуса круга
        /// </summary>
        public double Radius
        {
            get => _radius;
            set
            {
                if (value == 0 | value < 0)
                    throw new ValueEqualsOrLessZeroException("Value must be greater than 0");
                _radius = value;
                _diametr = value * 2;
            }
        }
        /// <summary>
        /// Значение диаметра круга
        /// </summary>
        public double Diametr
        {
            get => _diametr;
            set
            {
                if (value == 0 | value < 0)
                    throw new ValueEqualsOrLessZeroException("Value must be greater than 0");
                _diametr = value;
                _radius = value / 2;
            }
        }
        private Circle() { }
        private Circle(double radius)
        {
            if (radius == 0 | radius < 0)
                throw new ValueEqualsOrLessZeroException("Value must be greater than 0");
            Radius = radius;
            Diametr = radius * 2;
        }
        public double Area() => Math.PI * Math.Pow(Radius, 2);
        /// <summary>
        /// Свойство предоставляющее фабрику создания кругов
        /// </summary>
        public static CircleFactory Factory => new();
        /// <summary>
        /// Фабрику создания кругов
        /// </summary>
        public class CircleFactory
        {
            /// <summary>
            /// Создания круга по его радиусу
            /// </summary>
            /// <param name="raduis">Значение радиуса</param>
            /// <returns></returns>
            public Circle CreateCircleByRadius(double raduis)
                    => new Circle(raduis);
            /// <summary>
            /// Создания круга по его диаметру
            /// </summary>
            /// <param name="diametr">Значение диаметра</param>
            /// <returns></returns>
            public Circle CreateCircleByDiametr(double diametr)
                    => new Circle(diametr / 2);
        }

    }
}
