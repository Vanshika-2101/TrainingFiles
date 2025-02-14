using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Parallel_ConsoleApp
{
    internal class AsynchronousClass
    {


        //public static void Test()
        //{
        //    Console.WriteLine("Test started...");
        //    Thread.Sleep(TimeSpan.FromSeconds(5));
        //    Console.WriteLine('\n');
        //    Console.WriteLine("Test ended!");
        //}

        //public static async void Test()
        //{
        //    Console.WriteLine("Test started...");
        //    await Task.Delay(TimeSpan.FromSeconds(5));
        //    Console.WriteLine('\n');
        //    Console.WriteLine("Test ended!");
        //}

        public static async Task Wait()
        {
            Console.WriteLine("Wait started");
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine('\n');
            Console.WriteLine("Wait ended");
        }
        public async static void Test()
        {
            Console.WriteLine("Test started...");
            await Wait();
            Console.WriteLine("Test ended!");
        }

        public async Task<string> GetCompany()
        {
            return "IVP";
        }

        public async Task<EmployeeModel> GetEmployees()
        {
            EmployeeModel emp = new EmployeeModel()
            {
                Id = 10,
                Name = "Nikhil",
                Salary = 123458765d
            };
            //await Task.Delay(TimeSpan.FromSeconds(5));
            return emp;
        }

        public async Task FetchInfo()
        {
            string cname = await GetCompany();
            EmployeeModel emp = await GetEmployees();
            Console.WriteLine($"{cname} - {emp.Id} - {emp.Name} - {emp.Salary}");
        }

    }
}
