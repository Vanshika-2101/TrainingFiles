using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IVPLibrary_DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace IVPLibraryConsole.BookRepo
{
    public class BookOperations : IBook
    {
        public async Task FetchAllBooks()
        {
            using ApplicationDBContext context = new ApplicationDBContext();
            var books = await context.Books.ToListAsync();
            foreach (var book in books)
            {
                Console.WriteLine($"{book.BookId} - {book.Title} - {book.ISBN} - {book.Price} - {book.PUblisher_Id}");
            }
        }
    }
}
