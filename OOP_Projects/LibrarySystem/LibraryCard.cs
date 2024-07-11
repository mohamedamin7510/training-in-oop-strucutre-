using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class LibraryCard
    {
        string ID { get; set; }
        public LibraryCard(string userid)
        {
            this.ID = userid;
        }

    }
}
