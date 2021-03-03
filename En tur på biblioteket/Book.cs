using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace En_tur_på_biblioteket
{
    class Book
    {
        //Here are both my list for borrowing books and all the books.
        public static List<string> book = new List<string>();
        public static List<string> borrowBook = new List<string>();

        public void AddBook(string name)
        {
            book.Add(name);
        }

        public void AddAllBooks()//Here is the list of books that can be borowed.
        {
            book.Add("Harry Potter and the Philosopher's Stone");
            book.Add("Harry Potter and the Chamber of Secrets");
            book.Add("Harry Potter and the Prisoner of Azkaban");
            book.Add("Harry Potter and the Goblet of Fire");
            book.Add("Harry Potter and the Order of the Phoenix");
            book.Add("Harry Potter and the Half-Blood Prince");
            book.Add("Harry Potter and the Deathly Hallows");
        }
    }
}
