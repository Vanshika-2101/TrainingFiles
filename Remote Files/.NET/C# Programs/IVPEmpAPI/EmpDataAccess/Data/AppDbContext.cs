using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmpModels.Models;

namespace EmpDataAccess.Data
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        //{

        //}
        public DbSet<Employee> Employees {  get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=192.168.0.13\\sqlexpress,49753; Database=HR_DB_3686; User Id=sa; Password=sa@12345678; TrustServerCertificate=True;");
            //base.OnConfiguring(options);
        }

    }
}
