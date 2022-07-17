namespace Task2
{
    /// <summary>
    /// Класс с дополнительными методами сортировки
    /// </summary>
    static class MySort
    {
        /// <summary>
        /// Сортировка для списка People от А до Я
        /// </summary>
        /// <param name="peoples"></param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        public static List<People> IncreasingSort(List<People> peoples)
        {
            if (peoples != null && peoples.Count != 0)
            {
                for (int i = 0; i < peoples.Count; i++)
                    for (int j = i + 1; j < peoples.Count; j++)
                        if (peoples[i].SecondName[0] > peoples[j].SecondName[0])
                        {
                            var temp = peoples[i];
                            peoples[i] = peoples[j];
                            peoples[j] = temp;
                        }

                return peoples;
            }
            else
                throw new NullReferenceException();
        }

        /// <summary>
        /// Сортировка для списка People от Я до А
        /// </summary>
        /// <param name="peoples"></param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        public static List<People> DecreasingSort(List<People> peoples)
        {
            if (peoples != null && peoples.Count != 0)
            {
                for (int i = 0; i < peoples.Count; i++)
                    for (int j = i + 1; j < peoples.Count; j++)
                        if (peoples[i].SecondName[0] < peoples[j].SecondName[0])
                        {
                            var temp = peoples[i];
                            peoples[i] = peoples[j];
                            peoples[j] = temp;
                        }

                return peoples;
            }
            else
                throw new NullReferenceException();
        }
    }
}
