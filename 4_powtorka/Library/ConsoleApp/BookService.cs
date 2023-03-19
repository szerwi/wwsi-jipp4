using Library.Domain;
using Library.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class BookService
    {
        private BooksRepository _repository;

        public BookService(BooksRepository booksRepository)
        {
            _repository = booksRepository;
        }

        public void AddBook()
        {
            Console.Write("\nInsert book's title: ");
            string title = Console.ReadLine();
            Console.Write("\nInsert book's author: ");
            string author = Console.ReadLine();
            Console.Write("\nInsert book's publication year: ");
            int publicationYear = int.Parse(Console.ReadLine());
            Console.Write("\nInsert book's ISBN: ");
            string ISBN = Console.ReadLine();
            Console.Write("\nInsert book's availability: ");
            int productsAvailable = int.Parse(Console.ReadLine());
            Console.Write("\nInsert book's price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            _repository.Insert(new Library.Domain.Book(title, author, publicationYear, ISBN, productsAvailable, price));
        }

        public void RemoveBook()
        {
            Console.Write("\nInsert book's title to delete: ");
            string title = Console.ReadLine();

            _repository.RemoveByTitle(title);
        }

        public void ListBooks()
        {
            Console.WriteLine("Books list");
            int id = 0;
            foreach(Book book in _repository.GetAll())
            {
                Console.WriteLine($"{id}. {book.ToString()}");
                ++id;
            }
        }

        public void ChangeState()
        {
            Console.Write("\nInsert book's title to change: ");
            string title = Console.ReadLine();
            Console.Write("\nEnter new state: ");
            int state = int.Parse(Console.ReadLine());
            _repository.ChangeState(title, state);
        }
    }
}
