using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;

namespace _14LabTask
{
    public class MyDictionary<TKey, TValue> : IEnumerable<TKey>
    {
        Dictionary<TKey, TValue> stud = new Dictionary<TKey, TValue>();

        public int Count
        {
            get { return stud.Count; }
        }

        public MyDictionary(IDictionary<TKey, TValue> c)
        {
            stud = new Dictionary<TKey, TValue>(c.Count);

            var keys = c.Keys;

            foreach (var x in keys)
            {
                stud.Add(x, c[x]);
            }
        }

        public MyDictionary()
        { }

        public MyDictionary(int size)
        {
            stud = new Dictionary<TKey, TValue>();
        }

        public ICollection<KeyValuePair<TKey, TValue>> keyValuePairs()
        {
            return stud.ToList();
        }

        public void Add(TKey key, TValue value)
        {
            stud.Add(key, value);
        }

        public void Remove(TKey obj)
        {
            if (!stud.ContainsKey(obj))
            {
                Console.WriteLine("Элемент в коллекции не найден");
            }
            else
            {
                Console.WriteLine($"Элемент с ключом {obj} удален из коллекции");
                stud.Remove(obj);
            }
        }

        public void ShowCollection()
        {
            if (this.Count == 0)
                Console.WriteLine("Коллекция пустая");
            else
            {
                var keys = stud.Keys;

                foreach (var x in keys)
                {
                    Console.WriteLine($"{x} {stud[x]}");
                }
            }
        }

        public TKey this[int ind]
        {
            get
            {
                Console.WriteLine(stud.Count);
                if (ind < 0 || ind >= Count) throw new IndexOutOfRangeException();
                Console.WriteLine($"{stud.Keys.ElementAt(ind)} | {stud.Values.ElementAt(ind)}");
                return stud.Keys.ElementAt(ind);
            }
            set { }
        }

        //интерфейс IEnumerable
        public IEnumerator<TKey> GetEnumerator()
        {
            foreach (var x in stud.Keys)
                yield return x;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}