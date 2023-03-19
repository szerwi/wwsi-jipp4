using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Domain;
using Library.Persistence;

namespace ConsoleApp
{
    internal class OrderService
    {
        private OrdersRepository _repository;
        public OrderService(OrdersRepository ordersRepository) {
            _repository = ordersRepository;
        }

        public void PlaceOrder()
        {
            Order order = new Order();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Available commands: add, end");
                string command = Console.ReadLine();
                switch(command)
                {
                    case "add":
                        Console.Write("Book ID: ");
                        int bookID = int.Parse(Console.ReadLine());
                        Console.Write("\nCount: ");
                        int count = int.Parse(Console.ReadLine());

                        BookOrdered bookOrdered = new BookOrdered();
                        bookOrdered.BookId = bookID;
                        bookOrdered.NumberOrdered = count;

                        order.AddBooksOrdered(bookOrdered);
                        break;
                    case "end":
                        _repository.Insert(order);
                        return;
                        break;
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            }
        }

        public void ListAll()
        {
            foreach(Order order in _repository.GetAll())
            {
                Console.WriteLine(order.ToString());
            }
        }
    }
}
