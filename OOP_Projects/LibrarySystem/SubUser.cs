using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public delegate void ChooseOperationDelegate(Book book);

    public class SubUser : SuperUser
    {

        LibraryCard librarycard { get; set; }

        public SubUser(string name, float age, LibraryCard l)
        {
            this.librarycard = l;
            this.Age = age;
            this.Name = name;

        }

        public void pointer(Book book, ChooseOperationDelegate del)
        {
            del(book);
        }

    }
}
