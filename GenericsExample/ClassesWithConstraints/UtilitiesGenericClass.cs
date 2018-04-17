using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class UtilitiesGenericClass<T> where T : IComparable
    {
        //these are the different constrainst you can set on the generic classess / methods,

        // where T @ IComparable //where types set are comparable with each other
        // where T @ Product //class name / object type
        // where T @ struct
        // where T @ class
        // where T @ new()

        public T Max(T a, T b)
        {
            if (a.CompareTo(b) > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        //won't work, as not implementing new()
        //the real solution is in DefaultConstructorExample.cs
        //public void DoSAomething(T value)
        //{
            //var obj = new T();
        //}
    }
}
