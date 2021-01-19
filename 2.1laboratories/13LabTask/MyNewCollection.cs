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

        public MyNewCollection()
        {
            CollectionName = "NoName";
        }

        public MyNewCollection(string n)
        {
            CollectionName = n;
        }

        public MyNewCollection(ICollection<T> collection, string n) : base(collection)
        {
            CollectionName = n;
        }

        public new void Add(T obj)
        {
            base.Add(obj);
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(this.CollectionName, "add", obj));
        }

        public void AddDefault()
        {
            T obj = (T)new Challenge();
            base.Add(obj);
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(this.CollectionName, "add", obj));
        }

        public bool Remove(int j)
        {
            if (j >= 0 && j < base.Count)
            {
                OnCollectionCountChanged(this, new CollectionHandlerEventArgs(this.CollectionName, "delete", base[j]));
                base.Remove(base[j]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Length //получение кол-ва содержащихся элементов в коллекции
        {
            get //только для чтения
            {
                return Count;
            }
        }

        public new T this[int index]
        {
            get
            {
                return base[index];
            }
            set
            {
                OnCollectionReferenceChanged(this, new CollectionHandlerEventArgs(this.CollectionName, "changed", base[index]));
                base[index] = value;
            }
        }

        #region События
        public event CollectionHandler CollectionCountChanged; //событие, вызванное добавлением или удалением элементов
        public event CollectionHandler CollectionReferenceChanged; //событие, вызванное изменением ссылок
        #endregion

        #region Обработчики событий
        //защищенные процедуры: проверка существования события при попытке принять соответсвующее сообщени
        public virtual void OnCollectionCountChanged(object source, CollectionHandlerEventArgs args)
        {
            CollectionCountChanged?.Invoke(source, args);
        }

        public virtual void OnCollectionReferenceChanged(object source, CollectionHandlerEventArgs args)
        {
            CollectionReferenceChanged?.Invoke(source, args);
        }
        #endregion
    }
}

    

