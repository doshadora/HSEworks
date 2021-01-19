using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;

namespace _13LabTask
{
    class MyCollection<T> : IEnumerable<T>
        where T : Challenge
    {
        T[] queue;
        int count;

        public int Count
        {
            get { return count; }
            set
            {
                if (value >= 0) count = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        public MyCollection()
        {
            queue = new T[0];
        }

        public MyCollection(int size)
        {
            Count = size;
            queue = new T[Count];
        }

        public MyCollection(ICollection<T> c)
        {
            queue = new T[c.Count];
            Count = c.Count;
            int i = 0;
            foreach (T el in c)
            {
                queue[i++] = el;
            }
        }

        public void Add(T obj)
        {
            bool add = false;
            int index = 0;

            while (index < Count)
            {
                if (queue[index] == null)
                {
                    queue[index] = obj;
                    add = true;
                    return;
                }

                index++;
            }

            if (!add)
            {
                T[] temp = new T[++Count];
                queue.CopyTo(temp, 0);
                temp[Count - 1] = obj;
                queue = temp;
            }
        }

        public void Remove(T obj)
        {
            if (Count > 0)
            {
                T temp = queue[0];
                Count--;
                T[] temp_q = new T[Count];

                for (int i = 0; i < Count; i++)
                    temp_q[i] = queue[i + 1];

                queue = temp_q;
            }
            else
                throw new InvalidOperationException("Коллекция пуста");
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException();

                return queue[index];
            }
            set
            {
                if (index > 0 || index >= Count)
                    throw new IndexOutOfRangeException();

                queue[index] = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyQueueEnumerator<T>(queue);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
