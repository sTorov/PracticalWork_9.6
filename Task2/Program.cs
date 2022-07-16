namespace Task2
{
    class Program
    {
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
            Console.OutputEncoding = System.Text.Encoding.UTF7;

            List<People> peoples = GetPeoples();

            NumberReader numberReader = new NumberReader();
            numberReader.NumberReaderEvent += Sort;

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
                        e.PrintOneOrTwoException();
                    else
                    {
                        PrintOtherException(ex);
                        break;
                    }
                }                
            }

            Console.ReadKey();
        }

        static void Sort(List<People> peoples, int number)
        {
            switch (number)
            {
                case 1:
                    peoples.Sort(new PeopleIncreasing());
                    PrintPeople(peoples, "Сортировка А-Я");
                    break;
                case 2:
                    peoples.Sort(new PeopleDecreasing());
                    PrintPeople(peoples, "Сортоировка Я-А");
                    break;
            }
        }

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

        static void PrintOtherException(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
        }        
    }    
}