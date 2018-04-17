using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class GenericList<T>
    {
        private T t;

        //T is a type passed in via the angled brackets <>
        public void Add(T datatypein)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }

    }
}
