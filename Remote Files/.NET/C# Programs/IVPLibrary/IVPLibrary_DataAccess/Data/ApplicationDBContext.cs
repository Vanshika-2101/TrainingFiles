using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore; //gives DbContext class
using IVPLibrary_Models.Models; //to get Books reference

namespace IVPLibrary_DataAccess.Data
{
    public class ApplicationDBContext :DbContext
    {
        public DbSet<Books> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<BookDetails> BookDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server = 192.168.0.13\\sqlexpress,49753; Database = IVPLibrary_3686; User Id = sa; Password = sa@12345678; TrustServerCertificate = True;").LogTo(Console.WriteLine, new[] {DbLoggerCategory.Database.Command.Name}, LogLevel.Information);

        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Books>().Property(x => x.Price).HasPrecision(10, 5);

            model.Entity<Books>().HasData(
                new Books()
                {
                    BookId = 1,
                    Title = ".NET Framework",
                    ISBN = "12B45",
                    Price = 1200.34m,
                    PUblisher_Id = 1
                },
                new Books()
                {
                    BookId = 2,
                    Title = "SQL Server",
                    ISBN = "72B45",
                    Price = 1500.99m,
                    PUblisher_Id = 1
                }
                );
            var bookList = new Books[]
            {
                new Books() {BookId = 3, Title = "Oracle", ISBN="00B45", Price=1000.34m, PUblisher_Id = 2},
                new Books() {BookId = 4, Title = "Java", ISBN = "99B45", Price = 2000.99m, PUblisher_Id = 3 },
                new Books() {BookId = 5, Title = "ReactJS", ISBN ="34B45", Price = 3000.99m, PUblisher_Id = 3 }
            };

            model.Entity<Publisher>().HasData(
                new Publisher() {PUblisher_Id = 1, Name = "IVP Publisher", Location = "Delhi" },
                new Publisher() {PUblisher_Id = 2, Name = "AYT Publisher", Location = "Mumbai" },
                new Publisher() {PUblisher_Id = 3, Name = "Hedge Publisher", Location = "Bangalore" }
                );


            //Inserting Data

            model.Entity<Books>().HasData(bookList);

            //Check Constraint

            model.Entity<Books>().ToTable(x => x.HasCheckConstraint("CK_Books_Price", "Price > 0"));

            //Table name
            model.Entity<Product>().ToTable("Products");

            //Column name
            model.Entity<Product>().Property(a => a.ProductName).HasColumnName("Name");
            //Not null Constraint

            model.Entity<Product>().Property(a=> a.ProductName).IsRequired();
            //Check Constraint

            model.Entity<Product>().ToTable(x => x.HasCheckConstraint("CK_Product_Price", "Price > 0"));

            //Primary Key
            model.Entity<Product>().HasKey(a=> a.ProductId);
            //Max Length

            model.Entity<Product>().Property(a => a.ProductName).HasMaxLength(100);

            //Not Mapped
            model.Entity<Product>().Ignore(a => a.Discount);

            //Composite PK
            model.Entity<BookAuthorMap>().HasKey(x => new { x.AuthorId, x.BookId });

        }




    }
}
