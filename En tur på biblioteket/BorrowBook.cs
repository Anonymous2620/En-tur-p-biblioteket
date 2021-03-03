using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace En_tur_på_biblioteket
{
    class BorrowBook
    {
        public static Stack stackOfBooks = new Stack();

        public static void Loan(string book)//This is where i borrow the book and it is placed into my list of borrowed books.
        {
            if (Book.book.Contains(book))
            {
                stackOfBooks.Push(book);
                Book.book.Remove(book);
                Book.borrowBook.Add(book);
                Console.WriteLine("This book is now borrowed");

                Thread.Sleep(2000);
                Console.Clear();
                LoadBookMenu.LoadMenu();
            }
            else//This is the message I get when I don't type the book name properly.
            {
                Console.WriteLine("The book name is invalid. Please copy and paste the whole book name");
                Thread.Sleep(2000);
                Console.Clear();
                LoadBookMenu.LoadMenu();
                return;
            }
        }
    }
}
