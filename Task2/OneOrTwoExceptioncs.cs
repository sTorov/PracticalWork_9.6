namespace Task2
{
    class OneOrTwoException : Exception
    {
        public string Value { get; }
        public OneOrTwoException(string message, string value) : base(message)
        {
            Value = value;
        }

        public void PrintOneOrTwoException()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{GetType().Name + ":"} {Message}");
            Console.WriteLine($"Введённое значение: {Value}\t Попробуйте снова!");
            Console.ResetColor();
        }
    }
}
