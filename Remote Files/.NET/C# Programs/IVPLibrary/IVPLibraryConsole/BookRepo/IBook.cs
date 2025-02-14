using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVPLibraryConsole.BookRepo
{
    public interface IBook
    {
        public Task FetchAllBooks();
    }
}
