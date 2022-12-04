using ShapeLibrary.Interfaces;
using ShapeLibrary.ShapeExceptions;

namespace ShapeLibrary
{
    /// <summary>
    /// Класс предоставляющий методы для расчета площадей разных фигур
    /// </summary>
    public static class ShapeArea
    {
        /// <summary>
        /// Расчитывает площадь для данной фигуры
        /// </summary>
        /// <param name="shape">Объект фигуры</param>
        /// <returns></returns>
        /// <exception cref="IsNotShapeException"></exception>
        public static double Calculate(object shape)
        {
            if (shape is IShape _shape)
                return _shape.Area();
            throw new IsNotShapeException("Object is not a shape, area calculation is not possible");
        }
    }
}
