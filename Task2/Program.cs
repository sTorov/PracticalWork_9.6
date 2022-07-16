namespace Task2
{
    class OneOrTwoException : Exception
    {
        public string Value { get; }
        public OneOrTwoException(string message, string value) : base(message) 
        { 
            Value = value;
        }
    }

    
    class Program
    {
        static List<People> GetPeoples()
        {
            List<People> peoples = new List<People>();

            peoples.Add(new People("Иван", "Иванов", "Иванович"));
            peoples.Add(new People("Пётр", "Сидоров", "Владимирович"));
            peoples.Add(new People("Дмитрий", "Петров", "Генадиевич"));
            peoples.Add(new People("Александр", "Митрофанов", "Викторович"));
            peoples.Add(new People("Фёдор", "Шишкин", "Багданович"));

            return peoples;
        }

        static void PrintPeople(List<People> peoples, string lable)
        {
            Console.WriteLine(lable);
            Console.WriteLine("_______________________________________");
            foreach (var people in peoples)
                Console.WriteLine($"{people.SecondName, -12} {people.FirstName, -12} {people.LastName}");

            Console.WriteLine("_______________________________________");
            Console.WriteLine();
        }

        static void PrintException(OneOrTwoException ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{ex.GetType().Name + ":"} {ex.Message}");
            Console.WriteLine($"Введённое значение: {ex.Value}");
            Console.ResetColor();
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF7;

            List<People> people = GetPeoples();
            PrintPeople(people, "Список до сортировки");

            NumberReader numberReader = new NumberReader();
            numberReader.NumberReaderEvent += Sort;

            try
            {
                numberReader.Read();
            }
            catch (OneOrTwoException ex)
            {
                PrintException(ex);
            }

            Console.ReadKey();
        }

        static void Sort(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Введено значение 1");
                    break;
                case 2:
                    Console.WriteLine("Введено значение 2");
                    break;
            }
        }

        class NumberReader
        {
            public delegate void NumberReaderDelegate(int value);
            public event NumberReaderDelegate NumberReaderEvent;

            public void Read()
            {
                Console.WriteLine("Введите число 1 или 2 для сортировки\n1 - сортировка А-Я\n2 - сортировка Я-А");
                string value = Console.ReadLine();
                int.TryParse(value, out int result);

                if (result != 1 && result != 2)
                    throw new OneOrTwoException("Введённое значение должно быть 1 или 2", value);

                NumberEntered(result);
            }

            protected void NumberEntered (int number)
            {
                NumberReaderEvent?.Invoke(number);
            }
        }
    }

    
}