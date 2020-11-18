using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _12LabTask
{
    internal class MyQueueEnumerator<T> : IEnumerator<T> where T : Challenge
    {
        T[] queue;
        int position = -1;

        public MyQueueEnumerator(T[] queue)
        {
            this.queue = queue;
        }

        public T Current
        {
            get
            {
                if (position == -1 || position >= queue.Count())
                    throw new InvalidOperationException();

                return queue[position];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose() { }

        public bool MoveNext()
        {
            if (position < queue.Count() - 1)
            {
                position++;
                return true;
            }
            else return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}