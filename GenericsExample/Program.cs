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
            Book myBook = new Book(123456789, "The Wind in the Willows", 3.99F);
            GenericList<Book> myBookList = new GenericList<Book>();
            myBookList.Add(myBook);
            //location of all generic collection types
            //System.Collections.Generic.

            GenericDictionary<string, Book> myGenDictExample = new GenericDictionary<string, Book>();

            myGenDictExample.Add("1234", myBook);

            var mynumber = new Nullable<int>(5);
            Console.WriteLine("My Number Has Valeu? : " + mynumber.HasValue);
            Console.WriteLine("MyNumber has value of ? : " + mynumber.GetValueOrDefault());
            Console.ReadLine();
        }
                
    }
}
