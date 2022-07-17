namespace Task2
{
    /// <summary>
    /// Описание взаимодействия со значением, введённым с клавиатуры
    /// </summary>
    class NumberReader
    {
        public delegate void NumberReaderDelegate(List<People> peoples, int value);
        public event NumberReaderDelegate NumberReaderEvent;

        /// <summary>
        /// Чтение введённого значения с клавиатуры, его проверка на корректность.<br/>
        /// Вызов метода NumberEntered, вызывающего событие NumberReaderEvent
        /// </summary>
        /// <param name="peoples"></param>
        /// <exception cref="OneOrTwoException"></exception>
        public void Read(List<People> peoples)
        {
            Console.WriteLine("Введите число 1 или 2 для сортировки по фамилии\n1 - сортировка А-Я\n2 - сортировка Я-А");
            string value = Console.ReadLine();
            int.TryParse(value, out int result);

            if (result != 1 && result != 2)
                throw new OneOrTwoException("Введённое значение должно быть 1 или 2", value);

            NumberEntered(peoples, result);
        }

        /// <summary>
        /// Вызов события NumberReaderEvent
        /// </summary>
        /// <param name="peoples"></param>
        /// <param name="number"></param>
        protected void NumberEntered(List<People> peoples, int number)
        {
            NumberReaderEvent?.Invoke(peoples, number);
        }
    }
}
