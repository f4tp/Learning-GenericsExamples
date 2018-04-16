using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class ObjectList
    {
        //this is an older solution (pre-generics)as all objects are derrived from the 
        //object class, but...
        //...if a value is passed in as an argument to teh methods in here, it will have to be boxed...
        //...if a reference is passed in as an argument, it will have to be parsed to teh specific object type
        //Both of these things above have performance issues
        public static void Add(Object value)
        {

        }

        public object this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
