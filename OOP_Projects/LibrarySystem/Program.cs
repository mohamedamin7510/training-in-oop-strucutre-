using System.Linq;
using static LibrarySystem.Librariain;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object from library system
            var library = new Library();
            Console.Write("Are you (L)libraiain | (U)user: ");
            var Respone = Console.ReadLine().ToUpper();
            // Choosing the way of dealing with system 
            if (Respone == "L")
            {
                // information of librariain
                Console.Write("Please Enter Your Name: ");
                var Response = Console.ReadLine();
                Console.Write("Please Enter Your Age: ");
                float input = float.Parse(Console.ReadLine());
                Console.WriteLine($"Welcome {Response} in {library.LibraryName} ");
                var librariain = new Librariain(Respone, input);



                // choosing the operation that needed
                while (true)
                {


                    Console.WriteLine("Choose operation to do it (D)[DisplayBooks]  || (A)[AddBook]  || (R)[RemoveBook]");
                    var operation = Console.ReadLine().ToUpper();
                    if (operation == "D")
                    {
                        librariain.operation(null, (booku) => library.DisplayBooks());
                    }

                    else if (operation == "A")
                    {
                        librariain.operation(infobook(), (booku) => library.AddBook(booku));

                    }
                    else if (operation == "R")
                    {
                        librariain.operation(infobook(), (booku) => library.RemoveBook(booku));
                    }
                }



            }
            else if (Respone == "U")
            {
                // information of User
                Console.Write("Please Enter Your Name: ");
                var Response = Console.ReadLine();
                Console.Write("Please Enter Your Age: ");
                float input = float.Parse(Console.ReadLine());
                Console.Write("please enter your Id number: ");
                string ID = Console.ReadLine();
                var lcard = new LibraryCard(ID);
                Console.WriteLine($"Welcome {Response} in {library.LibraryName} ");
                var User = new SubUser(Respone, input, lcard);




                while (true)
                {
                    Console.WriteLine("Choose operation to do it (D)[DisplayBooks]  || (B)[borrow books] ");
                    var operation = Console.ReadLine().ToUpper();
                    if (operation == "D")
                    {
                        User.pointer(null, (booku) => library.DisplayBooks());
                    }

                    else if (operation == "B")
                    {
                        User.pointer(infobook(), (booku) => library.BorrowBook(booku));
                    }
                }



            }
            else
            {
                Console.WriteLine("Unknown User");
            }

            

        }


        public static Book infobook()
        {
            // information that you need As A book 
            var booku = new Book();
            Console.WriteLine("please enter Name of book && Author of book && Date ");
            booku.BookName = Console.ReadLine();
            booku.Author = Console.ReadLine();
            booku.DateOfPublishing = Console.ReadLine();
            return booku;
        }
    }
}
