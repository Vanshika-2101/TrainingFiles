using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreAssignment_Models.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAssignment_DataAccess.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }    
        public DbSet<Projects> Projects { get; set; }  
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=192.168.0.13\\sqlexpress,49753; Database=EFCoreAssignment_3686; User Id=sa; Password=sa@12345678; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<EmployeeDetails>().HasIndex(x => x.AadharNumber).IsUnique();
            model.Entity<EmployeeProject>().HasKey(x => new { x.EmployeeId, x.ProjectId });

            var EmployeeList = new Employees[]
            {
                new Employees() {EmployeeId = 1,FirstName = "Aaron", LastName = "Whitmore", Email = "aaron@ms", PhoneNumber = "515.123.4567", HireDate = DateTime.Now, Salary = 35000f, CommissionPct = 0.1, JobId = "SA_REP", ManagerId = 2, DepartmentId = 2},
                new Employees() {EmployeeId = 2,FirstName = "Bonnie", LastName = "Bennett", Email = "bonnie@ms", PhoneNumber = "515.123.4568", HireDate = DateTime.Now, Salary = 40000f, CommissionPct = 0.2, JobId = "IT_REP", ManagerId = 3, DepartmentId = 3},
                new Employees() {EmployeeId = 3,FirstName = "Caroline", LastName = "Forbes", Email = "caroline@ms", PhoneNumber = "515.123.4569", HireDate = DateTime.Now, Salary = 35000f, CommissionPct = 0.2, JobId = "IT_PROG", ManagerId = 3, DepartmentId = 3},
                new Employees() {EmployeeId = 4,FirstName = "Damon", LastName = "Salvatore", Email = "damon@ms", PhoneNumber = "515.123.4570", HireDate = DateTime.Now, Salary = 45000f, CommissionPct = 0.3, JobId = "MARK_REP", ManagerId = 5, DepartmentId = 4},
                new Employees() {EmployeeId = 5,FirstName = "Elena", LastName = "Gilbert", Email = "elena@ms", PhoneNumber = "515.123.4571", HireDate = DateTime.Now, Salary = 50000f, CommissionPct = 1.0, JobId = "CEO", ManagerId = 5, DepartmentId = 1}
            };

            model.Entity<Employees>().HasData(EmployeeList);
            model.Entity<Employees>().ToTable(x => x.HasCheckConstraint("CK_Employees_Salary", "Salary > 0"));

            var DepartmentList = new Departments[]
            {
                new Departments() {DepartmentId = 1, DepartmentName = "CEO", ManagerId = 5},
                new Departments() {DepartmentId = 2, DepartmentName = "Sales", ManagerId = 2},
                new Departments() {DepartmentId = 3, DepartmentName = "IT", ManagerId = 3},
                new Departments() {DepartmentId = 4, DepartmentName = "Marketing", ManagerId = 5}
            };
            model.Entity<Departments>().HasData(DepartmentList);

            var JobsList = new Jobs[]
            {
                new Jobs() {JobId = "SA_REP", JobTitle = "Sales Representative" , MaxSalary = 100000 , MinSalary = 10000},
                new Jobs() {JobId = "IT_REP", JobTitle = "IT Representative" , MaxSalary = 100000 , MinSalary = 10000},
                new Jobs() {JobId = "MARK_REP", JobTitle = "Marketing Representative" , MaxSalary = 100000 , MinSalary = 10000},
                new Jobs() {JobId = "IT_PROG", JobTitle = "IT Programmer" , MaxSalary = 100000 , MinSalary = 10000},
                new Jobs() {JobId = "CEO", JobTitle = "Chief Executive Officer" , MaxSalary = 100000 , MinSalary = 10000}
            };
            model.Entity<Jobs>().HasData(JobsList);

            var EmployeeDetailList = new EmployeeDetails[]
            {
                new EmployeeDetails() {EmployeeDetailsId = 1, EmployeeId = 1, Address = "Whitmore", AadharNumber = "527487659876" },
                new EmployeeDetails() {EmployeeDetailsId = 2, EmployeeId = 2, Address = "B Mystic Falls", AadharNumber = "527487659877" },
                new EmployeeDetails() {EmployeeDetailsId = 3, EmployeeId = 3, Address = "C Mystic Falls", AadharNumber = "527487659878" },
                new EmployeeDetails() {EmployeeDetailsId = 4, EmployeeId = 4, Address = "New Orleans", AadharNumber = "527487659879" },
                new EmployeeDetails() {EmployeeDetailsId = 5, EmployeeId = 5, Address = "E Mystic Falls", AadharNumber = "527487659880" }
            };

            model.Entity<EmployeeDetails>().HasData(EmployeeDetailList);

            var ProjectList = new Projects[]
            {
                new Projects() {ProjectId = 001, ProjectName = "P001"},
                new Projects() {ProjectId = 002, ProjectName = "P002"},
                new Projects() {ProjectId = 003, ProjectName = "P003"},
                new Projects() {ProjectId = 004, ProjectName = "P004"},
                new Projects() {ProjectId = 005, ProjectName = "P005"}

            };
            model.Entity<Projects>().HasData(ProjectList);

            var EmpProjList = new EmployeeProject[]
            {
                new EmployeeProject() {ProjectId = 001, EmployeeId = 1},
                new EmployeeProject() {ProjectId = 001, EmployeeId = 2},
                new EmployeeProject() {ProjectId = 002, EmployeeId = 1},
                new EmployeeProject() {ProjectId = 001, EmployeeId = 3},
                new EmployeeProject() {ProjectId = 003, EmployeeId = 4},
                new EmployeeProject() {ProjectId = 004, EmployeeId = 4},
                new EmployeeProject() {ProjectId = 005, EmployeeId = 2}
            };
            model.Entity<EmployeeProject>().HasData(EmpProjList);
        }
    }
}
