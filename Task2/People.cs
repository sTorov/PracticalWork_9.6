namespace Task2
{
    /// <summary>
    /// Класс, описывающий объекты типа People
    /// </summary>
    class People
    {
        public string FirstName { get; }
        public string SecondName { get; }
        public string LastName { get; }

        /// <summary>
        /// Конструктор, назначающий следующие свойства объекта:<br/>
        /// firstName - Имя<br/>
        /// secondName - Фамилия<br/>
        /// lastName - Отчество
        /// </summary>
        /// <param name="firtsName"></param>
        /// <param name="secondName"></param>
        /// <param name="lastName"></param>
        public People(string firtsName, string secondName, string lastName)
        {
            FirstName = firtsName;
            SecondName = secondName;
            LastName = lastName;
        }

        /// <summary>
        /// Конструктор, присваивающий во все свойства объекта значение null
        /// </summary>
        public People() { }
    }
}
