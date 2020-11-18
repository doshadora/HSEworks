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
        public Queue<JournalEntry> journal = new Queue<JournalEntry>();

        public override string ToString()
        {
            foreach (var item in journal)
            {
                Console.WriteLine(item);
            }
            
            return
        }
    }
}
