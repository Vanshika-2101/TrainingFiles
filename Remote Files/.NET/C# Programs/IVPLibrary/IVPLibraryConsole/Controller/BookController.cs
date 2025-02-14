using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IVPLibraryConsole.BookRepo;

namespace IVPLibraryConsole.Controller
{
    public class BookController
    {
        IBook _book;

        public BookController(IBook book)
        {
            _book = book;
        }

        public async Task FetchBooks()
        {
            await _book.FetchAllBooks();
        }
    }
}
