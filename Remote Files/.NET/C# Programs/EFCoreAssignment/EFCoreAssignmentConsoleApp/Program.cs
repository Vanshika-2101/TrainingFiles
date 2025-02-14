using EFCoreAssignmentConsoleApp.Controller;
using EFCoreAssignmentConsoleApp.Repo;

namespace EFCoreAssignmentConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IJobs job = new JobOperations();
            JobController control = new JobController(job);
            //control.FetchJobs();
            //control.FetchJobId("SA_REP");
            //control.AddJob("MARK_EXEC", "Marketing Executive", 100000, 10000 );
            //control.DeleteJob("MARK_EXEC");

            IEmployees employees = new EmployeesOperations();
            EmployeesController controlEmp = new EmployeesController(employees);
            controlEmp.GetAllEmployees();
            //controlEmp.AddEmployee("Stefan", "Salvatore", "stefan@ms", "515.123.4572", DateTime.Now, "SA_REP", 30000f, 0.3, 2, 2);
            //controlEmp.DeleteEmployee(7);

            Console.ReadKey();
            
        }
    }
}
