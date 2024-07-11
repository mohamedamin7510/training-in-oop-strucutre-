using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Library
    {
        public string LibraryName = "noor Library";
        public static List<Book> AllBooks = new List<Book>{
            new Book() { BookName= "employee 1",Author ="author 1",DateOfPublishing = "1"},
            new Book() { BookName= "employee 2",Author ="author 2",DateOfPublishing = "2"}, 
            new Book() { BookName= "employee 3",Author ="author 3", DateOfPublishing = "3"} };
           




        



        public static List<Book> BorrowBooks = new List<Book>();



        internal  void DisplayBooks()
        {
            // Todo: logic display book  
            foreach (Book book in AllBooks) 
            {
                Console.WriteLine($"Book is ({book.BookName}) || Author is ({book.Author}) || publishing date is ({book.DateOfPublishing}) ");
            }

        }



        internal void BorrowBook(Book book)
        {
            // Todo: logic borrow book

                 BorrowBooks.Add(book);
                 Console.WriteLine($"the `{book.BookName}` is borrowed ,,done");
        }

        public void AddBook(Book book)
        {
                //logic Adding book  
                if (AllBooks.Count <= 100)
                {
                    AllBooks.Add(book);
                }
                else
                    Console.WriteLine("Sorry the library is completed.");

         }
         public  void RemoveBook(Book book)
         {
                // Todo: logic librariain Remove book 
                if (AllBooks.Count >= 1)
                {
                    for (int i = 0; i < AllBooks.Count; i++)
                    {
                        if (book.BookName == AllBooks[i].BookName)
                        {
                            AllBooks.RemoveAt(i);
                        }
                    }
                }
                else
                    Console.WriteLine("Sorry the library is empty.");
          }

        

    }
}
