namespace Task2
{
    class Program
    {
        /// <summary>
        /// Возвращает список из 5-и объектов People
        /// </summary>
        /// <returns></returns>
        static List<People> GetPeoples()
        {
            List<People> peoples = new List<People>();

            peoples.Add(new People("Иван", "Иванов", "Иванович"));
            peoples.Add(new People("Пётр", "Сидоров", "Владимирович"));
            peoples.Add(new People("Дмитрий", "Петров", "Генадиевич"));
            peoples.Add(new People("Александр", "Азов", "Викторович"));
            peoples.Add(new People("Фёдор", "Шишкин", "Багданович"));

            return peoples;
        }
        
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<People> peoples = GetPeoples();

            NumberReader numberReader = new NumberReader();
            numberReader.NumberReaderEvent += SwitchSort;

            while (true)
            {
                try
                {
                    PrintPeople(peoples, "Список до сортировки");
                    numberReader.Read(peoples);
                    break;
                }
                catch (Exception ex)
                {
                    if(ex is OneOrTwoException e)
                    {
                        e.PrintOneOrTwoException();
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        PrintOtherException(ex);
                        break;
                    }
                }                
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Выбор соответствующего способа сортировки переданного списка, взависимости от полученного значения.<br/> 1 - Сортировка А-Я<br/>2 - Сортировка Я-А
        /// </summary>
        /// <param name="peoples"></param>
        /// <param name="number"></param>
        static void SwitchSort(List<People> peoples, int number)
        {
            switch (number)
            {
                case 1:
                    peoples.Sort(new IncreasingSort());
                    PrintPeople(peoples, "Сортировка А-Я");
                    break;
                case 2:
                    peoples.Sort(new DecreasingSort());
                    PrintPeople(peoples, "Сортоировка Я-А");
                    break;
            }
        }

        /// <summary>
        /// Построчный вывод на консоль списка объектов People
        /// </summary>
        /// <param name="peoples"></param>
        /// <param name="lable"></param>
        /// <exception cref="Exception"></exception>
        static void PrintPeople(List<People> peoples, string lable)
        {
            if (peoples != null)
            {
                Console.WriteLine("\n" + lable);
                Console.WriteLine("_______________________________________");
                foreach (var people in peoples)
                    Console.WriteLine($"{people.SecondName,-12} {people.FirstName,-12} {people.LastName}");

                Console.WriteLine("_______________________________________");
                Console.WriteLine();
            }
            else
                throw new Exception("Список пуст!");
        }

        /// <summary>
        /// Вывод сообщения различных ошибок на консоль с применение форматирования
        /// </summary>
        /// <param name="ex"></param>
        static void PrintOtherException(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
        }        
    }    
}