using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class UtilitiesGenericMethod
    {
        public int Max(int a, int b)
        {
            //return a > b ? a : b;
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        //this does not work as you might not be able to aply a comparsion on
        //certain objects
        //public T Max<T>(T a, T b)
        //{
            //if (a > b)
            //{
                //return a;
            //}
            //else
            //{
               // return b;
            //}
        //the below solution is the way to do this
        //this is a generic method in a non generic class
        public T Max<T>(T a, T b) where T : IComparable
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
    }
}
