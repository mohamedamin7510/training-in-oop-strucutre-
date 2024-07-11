using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Librariain : SuperUser
    {
        public delegate void ChooseOperationDelegate(Book book);

        public Librariain(string name, float age)
        {
            base.Name = name;
            base.Age = age;
        }

        public void operation(Book book, ChooseOperationDelegate operation)
        {
            operation(book);
        }


    }
}
