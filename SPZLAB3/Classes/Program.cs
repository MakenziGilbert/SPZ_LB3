using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZLAB3.Classes
{
    public class Program
    {
        private string _name; // Название
        private string _oSType; // Тип ОС
        private string _manufacturer; // Изготовитель
        public DateTime InstalDate { get; set; }
        private string _version; // Версия
        public string _necessaryRam { get; set; } // Ram
        public string _frequencyCP { get; set; } //  Частота ЦП
        public string _spaceHDD { get; set; } // Пространство на HDD
        public List<string> blockedUsers = new List<string>();
        public string Name
        {
            get { return _name; }
            set 
            {
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentException($"{value}");
                _name = value;
            }
        }
        public string OSType
        {
            get { return _oSType; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException($"{value}");
                _oSType = value;
            }
        }
        public string Manufacturer
        {
            get { return _manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException($"{value}");
                _manufacturer = value;
            }
        }
        public string Version
        {
            get { return _version; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException($"{value}");
                _version = value;
            }
        }
        public Program(string name, string oSType, string manufacturer, string version) // Конструктор
        {
            Name = name;
            OSType = oSType;
            Manufacturer = manufacturer;
            InstalDate = DateTime.Now;
            Version = version;
            Random rnd = new Random();
            _necessaryRam = rnd.Next(1, 4096).ToString();
            _frequencyCP = Math.Round((rnd.NextDouble() + rnd.Next(1, 3)), 1).ToString();
            _spaceHDD = rnd.Next(1, 40).ToString();
        }

        public void UpdateVersion() // Обновить версию
        {
            Random rnd = new Random();
            _necessaryRam = (Int32.Parse(_necessaryRam) + rnd.Next(1, 100)).ToString();
            _frequencyCP =  Math.Round((double.Parse(_frequencyCP) + (0.1 + rnd.NextDouble() * (0.3 - 0.1))),2).ToString();
            _spaceHDD = (Int32.Parse(_spaceHDD) + rnd.Next(1, 5)).ToString();
            string[] splitVersion = _version.Split('.');
            int select = rnd.Next(1, 3);
            if (select == 2)
                splitVersion[0] = (Int32.Parse(splitVersion[0]) + 1).ToString();
            else
                splitVersion[1] = (Int32.Parse(splitVersion[1]) + rnd.Next(1, 5)).ToString();
            _version = splitVersion[0] + "." + splitVersion[1];
        }
        public void AddBlockedUser(string user) // Добавить заблокированого пользователя
        {
            if(!blockedUsers.Contains(user))
                blockedUsers.Add(user);
        }
        public void RemoveBlockedUser(string user) // Удалить заблок. пользователя
        {
            if(blockedUsers.Contains(user))
                blockedUsers.Remove(user);
        }
        public static bool operator >(Program first, Program second) // >
        {
            int count = 0;
            if (Int32.Parse(first._necessaryRam) > Int32.Parse(second._necessaryRam)) count++;
            else count--;
            if (double.Parse(first._frequencyCP) > double.Parse(second._frequencyCP)) count++;
            else count--;
            if (Int32.Parse(first._spaceHDD) > Int32.Parse(second._spaceHDD)) count++;
            else count--;
            if (count > 0) return true; //
            else return false;
        }
        public static bool operator <(Program first, Program second)
        {
            int count = 0;
            if (Int32.Parse(first._necessaryRam) < Int32.Parse(second._necessaryRam)) count++;
            else count--;
            if (double.Parse(first._frequencyCP) < double.Parse(second._frequencyCP)) count++;
            else count--;
            if (Int32.Parse(first._spaceHDD) < Int32.Parse(second._spaceHDD)) count++;
            else count--;
            if (count > 0) return true; //
            else return false;
        }
        public override string ToString() //  переопределение стринг
        {
            return $"{Name} - {Manufacturer}";
        }
    }
}
