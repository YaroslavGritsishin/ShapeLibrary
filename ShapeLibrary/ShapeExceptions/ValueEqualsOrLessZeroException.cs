namespace ShapeLibrary.ShapeExceptions
{
    /// <summary>
    /// Возвращает ошибку если значение меньше или равно нулю
    /// </summary>
    public class ValueEqualsOrLessZeroException : Exception
    {
        /// <summary>
        /// Возвращает ошибку если значение меньше или равно нулю
        /// </summary>
        /// <param name="msg">Сообщение описывающее данную ошибку</param>
        public ValueEqualsOrLessZeroException(string msg) : base(msg) { }
    }
}
