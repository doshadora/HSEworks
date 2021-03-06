﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;


namespace _13LabTask
{
    class CollectionHandlerEventArgs
    {
        public string NameOfCollection
        {
            get;
            set;
        }

        public string TypeOfChanging
        {
            get;
            set;
        }

        public object ChangedElement
        {
            get;
            set;
        }

        public CollectionHandlerEventArgs(string name, string type, object element)
        {
            NameOfCollection = name;
            TypeOfChanging = type;
            ChangedElement = element;
        }

        public override string ToString()
        {
            return "Произошло изменение " + TypeOfChanging + " в коллекции: " + NameOfCollection + "\n. Изменился элемент " + " => " + ChangedElement;
        }
    }
}

