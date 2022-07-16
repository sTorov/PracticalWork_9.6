namespace Task2
{
    class NumberReader
    {
        public delegate void NumberReaderDelegate(List<People> peoples, int value);
        public event NumberReaderDelegate NumberReaderEvent;

        public void Read(List<People> peoples)
        {
            Console.WriteLine("Введите число 1 или 2 для сортировки\n1 - сортировка А-Я\n2 - сортировка Я-А");
            string value = Console.ReadLine();
            int.TryParse(value, out int result);

            if (result != 1 && result != 2)
                throw new OneOrTwoException("Введённое значение должно быть 1 или 2", value);

            NumberEntered(peoples, result);
        }

        protected void NumberEntered(List<People> peoples, int number)
        {
            NumberReaderEvent?.Invoke(peoples, number);
        }
    }
}
