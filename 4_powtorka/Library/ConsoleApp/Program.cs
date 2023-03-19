using ConsoleApp;
using Library.Domain;
using Library.Persistence;

Book book = new Book(/*uzupelnij parametry*/);
BooksRepository repository = new BooksRepository();

Console.Write("Enter username: ");
string username = Console.ReadLine();

Console.Write("\nEnter password: ");
string password = Console.ReadLine();

if(username == "Admin" && password == "password")
{
    Console.WriteLine("\nAccess Granted");
}
else
{
    Console.WriteLine("\nAccess Denied");
}

BooksRepository booksRepository = new BooksRepository();
BookService bookService = new BookService(booksRepository);

OrdersRepository ordersRepository = new OrdersRepository();
OrderService orderService = new OrderService(ordersRepository);

while (true)
{
    Console.WriteLine("Available commands: add, delete, list, change, add order, list orders , exit");

    string text = Console.ReadLine();
    switch(text)
    {
        case "add":
            bookService.AddBook();
            break;
        case "delete":
            bookService.RemoveBook();
            break;
        case "list":
            bookService.ListBooks();
            break;
        case "change":
            bookService.ChangeState();
            break;
        case "add order":
            orderService.PlaceOrder();
            break;
        case "list orders":
            orderService.ListAll();
            break;
        case "exit":
            return;
            break;
        default:
            Console.WriteLine("Unknown command");
            break;
    }

    Console.WriteLine("Press any key...");
    Console.ReadKey();
    Console.Clear();
}