namespace Task2
{
    /// <summary>
    /// Исключение для обработки ситуаций, когда полученное значение отлично от 1 или 2
    /// </summary>
    class OneOrTwoException : Exception
    {
        /// <summary>
        /// Хранит полученное значение, вызвавшее исключение
        /// </summary>
        public string Value { get; }
        public OneOrTwoException(string message, string value) : base(message)
        {
            Value = value;
        }

        /// <summary>
        /// Вывод сообщение исключения OneOrTwoException на консоль с применением форматирования<br/>
        /// Также выводит на консоль значение, вызвавшее исключение
        /// </summary>
        public void PrintOneOrTwoException()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{GetType().Name + ":"} {Message}");
            Console.WriteLine($"Введённое значение: {Value}\t Попробуйте снова!");
            Console.ResetColor();
        }
    }
}
