using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample.ClassesWithConstraints
{
    class DefaultConstructerExample<T> where T : IComparable, new()
    {
        public void DoSAomething(T value)
        {
            var obj = new T();
        }
    }
}
