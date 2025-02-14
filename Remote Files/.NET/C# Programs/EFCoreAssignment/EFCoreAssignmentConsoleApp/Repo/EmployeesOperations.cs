using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreAssignment_DataAccess.Data;
using EFCoreAssignment_DataAccess.Migrations;
using EFCoreAssignment_Models.Models;

namespace EFCoreAssignmentConsoleApp.Repo
{
    internal class EmployeesOperations : IEmployees
    {
        public void FetchAllEmployees()
        {
            using ApplicationDBContext context = new ApplicationDBContext();
            var employees = context.Employees.ToList();
            foreach ( var employee in employees )
            {
                Console.WriteLine($"{employee.EmployeeId} - {employee.FirstName} {employee.LastName} - {employee.Email} - {employee.HireDate} - {employee.Salary} - {employee.CommissionPct} - Department: {employee.DepartmentId} - Manager: {employee.ManagerId} - Job: {employee.JobId} ");
            }
        }
        public void AddAnEmployee( string Fname, string Lname, string Mail, string Pno, DateTime Hdate, string JId, double Sal, double CommPct, int MId, int DId)
        {
            using ApplicationDBContext context = new ApplicationDBContext();
            Employees emp = new Employees();
            //emp.EmployeeId = Id;
            emp.FirstName = Fname;
            emp.LastName = Lname;
            emp.Email = Mail;
            emp.HireDate = Hdate;
            emp.PhoneNumber = Pno;
            emp.CommissionPct = CommPct;
            emp.DepartmentId = DId;
            emp.ManagerId = MId;
            emp.JobId = JId;
            emp.Salary = Sal;
            context.Employees.Add( emp );
            Console.WriteLine("Inserted a record in Employees table");
            context.SaveChanges();
        }
        public void DeleteAnEmployee(int Id)
        {
            using ApplicationDBContext context = new ApplicationDBContext();
            var employees = context.Employees.Where(x => x.EmployeeId == Id);
            foreach (var emp in employees)
            {
                context.Employees.Remove( emp );
                Console.WriteLine( emp.EmployeeId + " deleted" );
            }
            context.SaveChanges();
        }
    }
}
