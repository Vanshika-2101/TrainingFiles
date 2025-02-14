using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IVPLibrary_DataAccess.Data;
using IVPLibrary_Models.Models;
using Microsoft.EntityFrameworkCore;

namespace IVPLibraryConsole
{
    internal class CRUD_IVPLibrary
    {


        public async Task CRUD()
        {
            ApplicationDBContext context = new ApplicationDBContext();

            //context.Database.EnsureCreated();

            //Console.WriteLine(context.Database.GetPendingMigrations().Count());

            //context.Database.Migrate();

            //UPDATING RECORDS
            //var books = context.Books.Find(1);
            //books.Price *= 1.10m;
            //context.SaveChanges();

            //var books = context.Books.Where(u => u.Price > 1700);
            //foreach (var book in books)
            //{
            //    book.Price = book.Price * 1.20m;
            //}
            //await context.SaveChangesAsync();

            //var bookList = await context.Books.ToListAsync();
            //foreach (var book1 in bookList)
            //{
            //    Console.WriteLine($"{book1.BookId} - {book1.Title} - {book1.ISBN} - {book1.Price} - {book1.PUblisher_Id}");
            //}

            //DELETING RECORDS

            //Deleting single record
            //var book = context.Books.Find(5);
            //context.Books.Remove(book);
            //context.SaveChanges();

            //var bookList = context.Books.ToList();
            //foreach (var book1 in bookList)
            //{
            //    Console.WriteLine($"{book1.BookId} - {book1.Title} - {book1.ISBN} - {book1.Price} - {book1.PUblisher_Id}");
            //}

            //Deleting multiple records
            //var data = context.Books.Where(x => x.PUblisher_Id == 3);
            //foreach (var item in data)
            //{
            //    context.Books.Remove(item);
            //}
            //context.SaveChanges();

            //var bookList = context.Books.ToList();
            //foreach (var book1 in bookList)
            //{
            //    Console.WriteLine($"{book1.BookId} - {book1.Title} - {book1.ISBN} - {book1.Price} - {book1.PUblisher_Id}");
            //}

            //Pagination Methods: Take() and Skip()

            //var books = context.Books.Skip(0).Take(5);  //offset
            //var books = context.Books.Skip(2).Take(3);
            //var books = context.Books.Where(x=> x.Price>1500).Skip(0).Take(2).OrderByDescending(x=> x.ISBN);
            //foreach (var info in books)
            //{
            //    Console.WriteLine($"{info.BookId} - {info.Title} - {info.ISBN} - {info.Price} - {info.PUblisher_Id}");
            //}


            //Sorting

            //var b = context.Books.OrderBy(x => x.PUblisher_Id).ThenByDescending(x => x.Price);
            //var blist = context.Books.Where(x => x.Price > 1500).OrderBy(u => u.Title);
            //foreach (var info in blist)
            //{
            //    Console.WriteLine($"{info.BookId} - {info.Title} - {info.ISBN} - {info.Price} - {info.PUblisher_Id}");
            //}

            //CONTAINS, Like and Aggregations

            //var blist = context.Books.Where(x => x.Title.Contains("W"));
            //var blist = context.Books.Where(x => EF.Functions.Like(x.Title, "__e%"));
            //var blist = context.Books.Where(x => EF.Functions.Like(x.Title, "_q%"));
            //var blist = context.Books.Where(x => EF.Functions.Like(x.ISBN, "%[a-n]%"));
            //var b = context.Books.Where(x=> EF.Functions.Like(x.ISBN, "_2%")).Max(u=>u.Price);
            //var b = context.Books.Where(u => EF.Functions.Like(u.ISBN,"_2%")).Min(u => u.Price);
            //var b = context.Books.Where(u => EF.Functions.Like(u.ISBN,"_2%")).Average(u => u.Price);
            //var b = context.Books.Sum(u=> u.Price);
            //Console.WriteLine(b);

            //FIND method

            //var b = context.Books.Find(5);
            //Console.WriteLine($"{b.BookId} - {b.Title} - {b.ISBN} - {b.Price} - {b.PUblisher_Id}");

            //Single and SingleOrDefault

            //var b = context.Books.Single(u => u.ISBN == "12B45");
            //var b = context.Books.SingleOrDefault(u => u.PUblisher_Id == 3);
            //var b = context.Books.Single(u => u.PUblisher_Id == 100); //exception
            //var b = context.Books.SingleOrDefault(u => u.PUblisher_Id == 100); //no exception
            //Console.WriteLine($"{b.BookId} - {b.Title} - {b.ISBN} - {b.Price} - {b.PUblisher_Id}");

            //Filtering using WHERE

            //var blist = context.Books.Where(x => x.PUblisher_Id == 3);
            //var blist = context.Books.Where(x => x.Price > 1500);
            //var blist = context.Books.Where(x=> x.Price > 1500 || x.PUblisher_Id == 2);
            //foreach ( var info in blist )
            //{
            //    Console.WriteLine($"{info.BookId} - {info.Title} - {info.ISBN} - {info.Price} - {info.PUblisher_Id}");
            //}
            //var info = context.Books.Where(x => x.PUblisher_Id == 3).FirstOrDefault();
            //Console.WriteLine($"{info.BookId} - {info.Title} - {info.ISBN} - {info.Price} - {info.PUblisher_Id}");

            //TOP 1 record or First Rec

            //var info = context.Books.First();
            //var info = context.Books.FirstOrDefault();
            //Console.WriteLine($"{info.BookId} - {info.Title} - {info.ISBN} - {info.Price} - {info.PUblisher_Id}");
            //Console.WriteLine(context.Authors.FirstOrDefault()); //prevents breaking of application if data isn't present
            //var info = context.Books.FirstOrDefault(x => x.PUblisher_Id == 3);

            //INSERTING DATA

            //Books books = new Books()
            //{
            //    Title = "Git",
            //    Price = 1234.00m,
            //    ISBN = "56k67",
            //    PUblisher_Id = 2
            //};
            //var data = context.Books.Add(books);
            //context.SaveChanges();

            //Console.WriteLine(data);

            //FETCHING DATA

            //var bookList = context.Books.ToList();
            //foreach ( var book in bookList )
            //{
            //    Console.WriteLine($"{book.BookId} - {book.Title} - {book.ISBN} - {book.Price} - {book.PUblisher_Id}" );
            //}

            //var plist = context.Publishers.ToList();
            //foreach ( var publisher in plist )
            //{
            //    Console.WriteLine($"{publisher.PUblisher_Id} - {publisher.Name} - {publisher.Location}");
            //}


        }
    }
}
