using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignmentConsoleApp.Repo
{
    public interface IEmployees
    {
        public void FetchAllEmployees();
        public void AddAnEmployee( string Fname, string Lname, string Mail, string Pno, DateTime Hdate, string JId, double Sal, double CommPct, int MId, int DId  );
        public void DeleteAnEmployee(int Id);

    }
}
