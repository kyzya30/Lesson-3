using System;


namespace Task3
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        readonly string _dataFillBlank;

        public User(string login, string name, string surname, int age, string dataFill)
        {
            this.Login = login;
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this._dataFillBlank = dataFill;
        }

        public void ShowUserInfo()
        {
            Console.WriteLine("Логин: {0}, Имя: {1}, Фамилия: {2}, Возраст: {3}, Дата заполнения: {4}", Login, Name, Surname, Age, _dataFillBlank);
        }

    }
}
