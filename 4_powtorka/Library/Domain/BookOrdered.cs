using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    namespace Domain
    {
        public class BookOrdered
        {
            public BookOrdered() { }

            public int BookId { get; set; }
            public int NumberOrdered { get; set; }
        }
    }
}