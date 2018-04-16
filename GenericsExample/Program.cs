using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book(123456789, "The Wind in the Willows");
            GenericList<Book> myBookList = new GenericList<Book>();
            myBookList.Add(myBook);
        }
    }
}
