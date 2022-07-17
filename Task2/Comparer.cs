namespace Task2
{
    /// <summary>
    /// Реализация сортировки от А до Я пофамильно для класса People
    /// </summary>
    class IncreasingSort : IComparer<People>
    {
        public int Compare(People x, People y)
        {
            return x.SecondName.CompareTo(y.SecondName);
        }
    }

    /// <summary>
    /// Реализация сортировки от Я до А пофамильно для класса People
    /// </summary>
    class DecreasingSort : IComparer<People>
    {
        public int Compare(People x, People y)
        {
            return -x.SecondName.CompareTo(y.SecondName);
        }
    }
}
