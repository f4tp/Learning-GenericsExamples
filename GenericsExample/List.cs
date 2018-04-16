using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class List
    {
        //this was the solution to hold same type data types in a collection before generics...
        //...a class like this would have to be set up for each different object type you 
        //wanted to keep in the collection, 
        //...generics stops this
        public void Add(Object objectin)
        {

        }

        public int this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
