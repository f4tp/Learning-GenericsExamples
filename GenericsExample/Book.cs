using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class Book
    {

        public int Isbn;
        public string Title;


        public Book(int isbnin, string titlein)
        {
            this.Isbn = isbnin;
            this.Title = titlein;
        }
    }
}
