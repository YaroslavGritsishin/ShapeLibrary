namespace ShapeLibrary.ShapeExceptions
{
    /// <summary>
    /// Возвращает ошибку если объект не является фигурой
    /// </summary>
    public class IsNotShapeException : Exception
    {
        /// <summary>
        /// Возвращает ошибку если объект не является фигурой
        /// </summary>
        /// <param name="msg">Сообщение описывающее данную ошибку</param>
        public IsNotShapeException(string msg) : base(msg) { }
    }
}
