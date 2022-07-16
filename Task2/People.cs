namespace Task2
{
    class People
    {
        public string FirstName { get; }
        public string SecondName { get; }
        public string LastName { get; }

        public People(string firtsName, string secondName, string lastName)
        {
            FirstName = firtsName;
            SecondName = secondName;
            LastName = lastName;
        }

        public People()
        {
            FirstName = null;
            SecondName = null;
            LastName = null;
        }
    }
}
