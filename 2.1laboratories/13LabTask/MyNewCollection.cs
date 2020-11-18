using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;

namespace _13LabTask
{
    delegate void CollectionHandler(object source, CollectionHandlerEventArgs args);
    class MyNewCollection<T> : MyCollection<T>
        where T: Challenge
    {
        public string CollectionName { get; set; }

        public MyNewCollection() : base()
        {
            CollectionName = "NoName";
        }

        public MyNewCollection(int size, string n) : base(size)
        {
            CollectionName = n;
        }

        public MyNewCollection(ICollection<T> collection, string n) : base(collection)
        {
            CollectionName = n;
        }

        public new T this[int index]
        {
            get { return base[index]; }
            set
            {
                CollectionReferenceChanged(this, new CollectionHandlerEventArgs("changed", base[index]));
                base[index] = value;
            }
        }
               
        public new void Add(T obj)
        {
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs("add", obj));
            base.Add(obj);
        }

        public bool Remove(int j)
        {
            if (j >= 0 && j < base.Count)
            {
                OnCollectionCountChanged(this, new CollectionHandlerEventArgs("delete", base[j]));
                base.RemoveAt(j);
                return true;
            }
            else return false;
        }

        public void AddDefaults()
        {
        //    OnCollectionCountChanged(this, new CollectionHandlerEventArgs("add defaults", obj));
        //    base.Add(obj);
        }

        #region События
        public event CollectionHandler CollectionCountChanged; //событие, вызванное добавлением или удалением элементов
        public event CollectionHandler CollectionReferenceChanged; //событие, вызванное изменением ссылок
        #endregion

        #region Обработчики событий
        //защищенные процедуры: проверка существования обработчика при попытке принять соответсвующего сообщения
        public virtual void OnCollectionCountChanged(object source, CollectionHandlerEventArgs args)
        {
            if (CollectionCountChanged != null)
            {
                CollectionCountChanged(source, args);
            }
        }

        public virtual void OnCollectionReferenceChanged(object source, CollectionHandlerEventArgs args)
        {
            if (CollectionReferenceChanged != null)
            {
                CollectionReferenceChanged(source, args);
            }
        }
        #endregion
    }
}

    }
}
