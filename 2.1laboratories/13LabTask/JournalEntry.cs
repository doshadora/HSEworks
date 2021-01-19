using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;

namespace _13LabTask
{
    class JournalEntry
    {
        public string NameOfCollection  //автосвойство имени коллекции
        {
            get;
            set;
        }

        public string ChangedObject //автосвойство изменённого объекта
        {
            get;
            set;
        }

        public string TypeOfChanging //автосвойство типа изменения
        {
            get;
            set;
        }
        public JournalEntry(string name, string type, string obj) //конструктор создания элемента журнала
        {
            NameOfCollection = name;
            TypeOfChanging = type;
            ChangedObject = obj;
        }

        public override string ToString() //вывод инфы о записи журнала
        {
            return "В коллекции: " + NameOfCollection + " произошло изменение типа " + TypeOfChanging + "\n. для объекта: " + "=>" + ChangedObject;
        }
    }
}
