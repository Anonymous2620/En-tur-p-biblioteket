using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace En_tur_på_biblioteket
{
    class Program
    {
        public static int Choice { get; set; }
        public static string bookLoan { get; set; }
        public static string bookReturn { get; set; }
        static void Main(string[] args)
        {
            Book book = new Book();

            //Here all the books will be added to list.
            book.AddAllBooks();

            //THis is used for loading the menu.
            LoadBookMenu.LoadMenu();

            //Here you can choose between returning a book or borrowing one.
            while (true)
            {
                Console.Write("\n\nEnter a choice: ");
                try
                {
                    Choice = int.Parse(Console.ReadLine());
                }
                catch { Console.Clear(); LoadBookMenu.LoadMenu(); }

                switch (Choice)
                {
                    case 1:
                        Borrow();
                        break;

                    case 2:
                        Return();
                        break;

                    default:
                        Console.Clear();
                        LoadBookMenu.LoadMenu();
                        break;
                }
            }
        }

        //This is all the available books ready for borrowing.
        public static void Borrow()
        {
            Console.WriteLine("\n--------\n");
            if (Book.book.Count > 0)
            {
                Console.WriteLine("Available books: ");
                foreach (string item in Book.book)
                {
                    Console.WriteLine(item);

                }
            }//In this else it will tell me if i have already borrowed all the books.
            else
            {
                Console.WriteLine("All the books have been borrowed.");

                Thread.Sleep(1500);
                Console.Clear();
                LoadBookMenu.LoadMenu();
                return;
            }

            //Here i type or copy, paste the name of the book i want to borrow.
            Console.Write("\n\nCopy and paste the whole book name of your desired book: ");
            bookLoan = Console.ReadLine();
            BorrowBook.Loan(bookLoan);
        }


        public static void Return()
        {//Here all the books i have borrowed will be displayed in order by their name. 
            Console.WriteLine("\n--------\n");
            if (Book.borrowBook.Count > 0)
            {
                Console.WriteLine("Your Books: ");
                foreach (string item in Book.borrowBook)
                {
                    Console.WriteLine(item);
                }
            }
            else//In this else it will tell me if i haven't borrowed any book yet.
            {
                Console.WriteLine("You haven't borrowed any books yet. Return to this menu when you want to return your borrowed books.");

                Thread.Sleep(2500);
                Console.Clear();
                LoadBookMenu.LoadMenu();
                return;
            }
            //Here i will confirm my decision of returning a book by typing Yes for returning and No to keeping it.
            Console.Write("\n\nDo you want to return all your borrowed books? Write Yes or No accordingly to your decision: ");
            bookReturn = Console.ReadLine();

            ReturnBook.Return(bookReturn);
        }
    }
}
