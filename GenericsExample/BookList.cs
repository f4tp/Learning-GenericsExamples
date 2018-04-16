using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class BookList
    {

        public void Add(Book objectin)
        {

        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

   
}
