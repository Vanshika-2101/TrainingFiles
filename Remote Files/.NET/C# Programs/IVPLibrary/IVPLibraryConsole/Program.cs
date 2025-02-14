using IVPLibraryConsole.BookRepo;
using IVPLibraryConsole.Controller;

namespace IVPLibraryConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CRUD Using EFCore");

            CRUD_IVPLibrary lib = new CRUD_IVPLibrary();
            lib.CRUD();

            IBook book = new BookOperations();
            BookController control = new BookController(book);
            control.FetchBooks();

            Console.ReadLine();
        }
    }
}
