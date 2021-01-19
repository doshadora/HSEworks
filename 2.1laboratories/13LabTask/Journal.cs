using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;

namespace _13LabTask
{
    class Journal<T> : MyNewCollection<T>
        where T: Challenge
    {
        public List<JournalEntry> journal = new List<JournalEntry>();//переменная списка событий
        public Journal() : base() { }

        //обработчик события для класса-получателя
        public override void OnCollectionCountChanged(object source, CollectionHandlerEventArgs e)
        {
            JournalEntry je = new JournalEntry(e.NameOfCollection, e.TypeOfChanging, e.ChangedElement.ToString());
            journal.Add(je);
        }

        //обработчик события для класса-получателя
        public override void OnCollectionReferenceChanged(object source, CollectionHandlerEventArgs e)
        {
            JournalEntry je = new JournalEntry(e.NameOfCollection, e.TypeOfChanging, e.ChangedElement.ToString());
            journal.Add(je);
        }

        public override string ToString() //вывод содержимого на экран
        {
            if (journal.Capacity != 0)
            {
                string stroka = null;
                int i = 0;
                foreach (JournalEntry je in journal)
                {
                    stroka += "\n" + (i + 1) + " запись:\n\n " + je.ToString() + "\n";
                    i++;
                }
                return stroka;
            }
            else return "Журнал пустой!";
        }
    }
}
