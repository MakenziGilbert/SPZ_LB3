using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZLAB3.Classes
{
    delegate void ProgramManagerHandler(); // Делегат для события.
    class ProgramManagerEvent
    {
        public event ProgramManagerHandler programManagerEvent; // Событие 
        public void OnEvent() // Вызывает событие.
        {
            programManagerEvent?.Invoke(); // Вызвать.
        }
        public static void IncrementProgram()
        {
            ProgramManager.AmountOfPrograms++;
        }
        public static void IncrementUser()
        {
            ProgramManager.AmountOfUsers++;
        }
        public static void DecrementProgram()
        {
            ProgramManager.AmountOfPrograms--;
        }
        public static void DecrementUser()
        {
            ProgramManager.AmountOfUsers--;
        }
    }
    public class ProgramManager
    {
        public List<Program> ProgramList = new List<Program>();
        public List<User> UserList = new List<User>();
        public Dictionary<string, string> UserDictionary = new Dictionary<string,string>();
        public static int AmountOfPrograms { get; set; } // Количество програм
        public static int AmountOfUsers { get; set; } // Количество пользователей
        public string OsType { get; set; } // Тип ОС
        public string FrequencyCP { get; set; } //  Частота ЦП
        public string Ram { get; set; } // Ram
        public string SpaceHDD { get; set; } // Пространство на HDD
        public ProgramManager()
        {
            AmountOfPrograms = 0;
            AmountOfUsers = 0;
            OsType = "Windows";
            FrequencyCP = "3.8";
            Ram = "8000";
            SpaceHDD = "500";
        }
        public string PrintConfiguration()
        {
            return $"Частота процессора:{FrequencyCP} GHz, ОП: {Ram} Mb, HDD: {SpaceHDD} Gb, ОС: {OsType}";
        }
        public void AddProgram(Program program) // Дбавить программу
        {
            ProgramList.Add(program);
        }
        public void DeleteProgram(int index)
        {
            ProgramList.RemoveAt(index);
        }
        public void AddUser(User user) // Добавить пользователя
        {
            UserDictionary.Add(user.Name, user.Password);
            UserList.Add(user);
        }
        public void DeleteUser(string name)
        {
            UserDictionary.Remove(name);
            UserList.RemoveAll(x => x.Name == name);
        }
        public void UpdateThisProgram(int index) // Обновить передаваемую программу
        {
            ProgramList[index].UpdateVersion();
        }
        public bool CompareTwousers(User first, User second) // Сравнить юзеров
        {
            if (first == second)
                return true;
            else
                return false;
        }
        public bool CompareTwoprograms(Program first, Program second) // Сравнить программы
        {
            if (first > second)
                return true;
            else 
                return false;
        }
    }
}
