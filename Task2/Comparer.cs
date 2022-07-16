namespace Task2
{
    class PeopleIncreasing : IComparer<People>
    {
        public int Compare(People x, People y)
        {
            return x.SecondName.CompareTo(y.SecondName);
        }
    }

    class PeopleDecreasing : IComparer<People>
    {
        public int Compare(People x, People y)
        {
            return -x.SecondName.CompareTo(y.SecondName);
        }
    }
}
