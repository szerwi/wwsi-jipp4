using Library.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
    namespace Domain
    {
        public class Order
        {
            public Order()
            {
                Date = DateTime.Now;
                BooksOrderedList = new List<BookOrdered>();
            }

            public DateTime Date { get; set; }
            public List<BookOrdered> BooksOrderedList { get; set; }

            public void AddBooksOrdered(BookOrdered bookOrdered)
            {
                BooksOrderedList.Add(bookOrdered);
            }

            public override string ToString()
            {
                string str = "Order: " + Date;
                foreach(BookOrdered bookOrdered in BooksOrderedList)
                {
                    str += $" - Book: {bookOrdered.BookId} Count: {bookOrdered.NumberOrdered} ";
                }

                return str;
            }
        }
    }
}
