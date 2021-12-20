using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZLAB3.Classes
{
    public class User
    {
        private string _name; // имя
        private string _password; // Пароль
        public List<Program> programList = new List<Program>();
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException($"{value}");
                _name = value;
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException($"{value}");
                _password = value;
            }
        }
        public bool Authentication(string somePassword)// Аутентификация
        {
            if (somePassword == Password)
                return true;
            else return false;
        }
        public void CheckForBlocking(List<Program> program) // Проверить на блокировку программы
        {
            foreach(var item in program)
            if (item.blockedUsers.Contains(Name))
                programList.Remove(item);
        }
        public void AddProgramToList(Program program) // Добавить программу в список
        {
            if(!programList.Contains(program))
                programList.Add(program);
        }
        public void DeleteProgramFromlist(Program program) // Удалить программу со списка
        {
            if (programList.Contains(program))
                programList.Remove(program);
        }
        public static bool operator== (User first, User second)
        {
            return (first.programList.Count == second.programList.Count);
        }
        public static bool operator!= (User first, User second)
        {
            return (first.programList.Count != second.programList.Count);
        }
        public override string ToString() //  переопределение сттринг
        {
            return $"{Name}";
        }
    }
}
