using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreAssignmentConsoleApp.Repo;

namespace EFCoreAssignmentConsoleApp.Controller
{
    public class EmployeesController
    {
        IEmployees _Emp;
        public EmployeesController(IEmployees employees)
        {
            _Emp = employees;
        }

        public void GetAllEmployees()
        {
            _Emp.FetchAllEmployees();
        }

        public void AddEmployee( string Fname, string Lname, string Mail, string Pno, DateTime Hdate, string JId, double Sal, double CommPct, int MId, int DId)
        {
            _Emp.AddAnEmployee( Fname, Lname, Mail, Pno, Hdate, JId, Sal, CommPct, MId, DId);
        }
        public void DeleteEmployee(int Id)
        {
            _Emp.DeleteAnEmployee(Id);
        }
    }
}
