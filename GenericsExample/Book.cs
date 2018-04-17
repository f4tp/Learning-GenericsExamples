using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class Book: Product
    {

        public int Isbn;
        //public string Title;


        public Book(int isbnin, string titlein, float costin)
        {
            this.Isbn = isbnin;
            this.Title = titlein;
            this.Price = costin;
        }
    }
}
