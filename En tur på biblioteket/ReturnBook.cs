using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace En_tur_på_biblioteket
{
    class ReturnBook
    {
        public static void Return(string yesNoChoice)
        {
            //Here is a yes or no confrim choice when returning a book
            switch (yesNoChoice)
            {
                case "Yes":
                    string book = BorrowBook.stackOfBooks.Pop().ToString();
                    Book.book.Add(book);
                    Book.borrowBook.Remove(book);

                    Console.WriteLine("All borrowed books are now returned");

                    Thread.Sleep(1000);
                    Console.Clear();
                    LoadBookMenu.LoadMenu();
                    break;

                case "No":
                    Console.WriteLine("Returning to book menu");

                    Thread.Sleep(1000);
                    Console.Clear();
                    LoadBookMenu.LoadMenu();
                    break;
            }
        }
    }
}
