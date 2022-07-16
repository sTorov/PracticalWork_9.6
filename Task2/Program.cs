namespace Task2
{
    class OneOrTwoException : Exception
    {
        private int Value { get; }
        public OneOrTwoException(string message, int value) : base(message) 
        { 
            Value = value;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF7;

            List<string> exceptions = new List<string>();

            exceptions.Add("Иванов Д.Ф.");
            exceptions.Add("Петров П.А.");
            exceptions.Add("Сидоров С.С.");
            exceptions.Add("Шишкин И.Т.");
            exceptions.Add("Староверов М.Л.");

            Console.ReadKey();
        }
    }
}