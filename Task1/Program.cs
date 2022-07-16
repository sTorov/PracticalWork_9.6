namespace Task1
{
    class OneOrTwoException : Exception
    {
        public OneOrTwoException(string message) : base(message)  { }
    }
    
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF7;
            
            List<Exception> exceptions = new List<Exception>();

            exceptions.Add(new FileNotFoundException("Файл не найден!"));
            exceptions.Add(new StackOverflowException("Стек выполнения привысил размер стека!"));
            exceptions.Add(new DriveNotFoundException("Диск не доступен либо отсутствует!"));
            exceptions.Add(new IndexOutOfRangeException("Индекс находится за пределами границ массива или коллекции!"));
            exceptions.Add(new OneOrTwoException("Введённое значение должно быть 1 или 2!"));

            for (int i = 0; i < exceptions.Count; i++)
            {
                try
                {
                    throw exceptions[i];
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.GetType().Name + ":", -30} {ex.Message}");
                }
            }

            Console.ReadKey();
        }
    }
}