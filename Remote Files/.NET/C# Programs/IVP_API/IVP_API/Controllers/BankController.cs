using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IVP_API.Models;
using Microsoft.AspNetCore.Localization;

namespace IVP_API.Controllers
{
    [Route("api/[controller]")]
    //[Route("test")]
    [ApiController]
    public class BankController : ControllerBase
    {
        List<Bank> customers;
        public BankController()
        {
            customers = new List<Bank>()
            {
                new Bank() {CID = 10, CName = "Nikhil", Account = "Saving", Balance = 50000f},
                new Bank() {CID = 20, CName = "Jack", Account = "Joint", Balance = 25000f},
                new Bank() {CID = 30, CName = "Amit", Account = "Current", Balance = 40000f},
                new Bank() {CID = 40, CName = "Rose", Account = "Saving", Balance = 30000f},
                new Bank() {CID = 50, CName = "Neha", Account = "Joint", Balance = 20000f}
            };
        }

        [HttpGet("Customers")]
        public ActionResult<Bank> GetAllCustomers()
        {
            if (customers == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(customers.OrderBy(x => x.Balance).ToList());
            }
        }

        [HttpGet]
        [Route("Customer/{id:int:min(10)}")]
        public IActionResult GetCustomerById(int id)
        {
            var data = customers.Find(x => x.CID == id);
            if (data == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(data);
            }
        }

        [HttpGet("CustomerName/{id:int:min(10)}")]
        public ActionResult GetCustomerName(int id)
        {
            var data = customers.Find(x => x.CID == id);
            if (id > 1000)
            {
                return NotFound();
            }
            else if (data == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(data.CName);
            }
        }

        [HttpGet("Balance/{id:int:min(10)}")]
        public IActionResult GetCustomerBalance(int id)
        {
            var data = customers.Find(x => x.CID == id);
           
            return Accepted(data.Balance);
        }

        [HttpGet]
        [Route("Customer/{type:alpha}")]
        public IActionResult GetCustomerByAccount(string type)
        {
            var data = customers.Where(x => x.Account == type);
            return Ok(data);
        }

        //[HttpGet("Customers")]
        //public List<Bank> GetAllCustomers()
        //{
        //    var data = customers.OrderBy(x => x.Balance).ToList();
        //    return data;
        //}

        //[HttpGet]
        //[Route("Customer/{id:int:min(10)}")]
        //public Bank GetCustomerById(int id)
        //{
        //    var data = customers.Find(x => x.CID == id);
        //    return data;
        //}

        //[HttpGet("CustomerName/{id:int:min(10)}")]
        //public string GetCustomerName(int id)
        //{
        //    var data = customers.Find(x => x.CID == id);
        //    return data.CName;
        //}

        //[HttpGet("Balance/{id:int:min(10)}")]
        //public double GetCustomerBalance(int id)
        //{
        //    var data = customers.Find(x => x.CID == id);
        //    return data.Balance;
        //}

        //[HttpGet]
        //[Route("Customer/{type:alpha}")]
        //public IEnumerable<Bank> GetCustomerByAccount(string type)
        //{
        //    var data = customers.Where(x => x.Account == type);
        //    return data;
        //}


        ////Routing Constraint

        //[HttpGet]
        //[Route("Balance/{amount:int:min(0):max(20)}")]      //check constraint
        ////[Route("Balance/{amount:int:range(0,20)}")]
        //public string GetCustByBal(int amount)
        //{
        //    return "Customer details " + amount;
        //}

        //[HttpGet("Acc/{Type:length(10):alpha}")]
        //public string GetAccountsByTheirTypes(string Type)
        //{
        //    return $"Customer details with Type of account = {Type} are returned";
        //}

        //[HttpGet]
        //[Route("{name:regex(a(b|c))}")]
        //public string GetAccountsByName(string name)
        //{
        //    return $"Customer details with Name = {name} are returned";
        //}

        ////End of Routing Constraints

        ////Overriding base route
        //[HttpGet]
        //[Route("~/State")]
        //[Route("/branch")]
        //public string GetDetailsByState(string name)
        //{
        //    return $"Customer details by {name} state";
        //}

        //[HttpGet]
        //[Route("Employees")]
        //[Route("Emps")]
        //[Route("IVP/Employees")]
        //public List<Employee> GetEmployees()
        //{
        //    var emps = new List<Employee>()
        //    {
        //        new Employee(){Id=10, Name= "Nikhil", Salary = 20000f},
        //        new Employee(){Id=20, Name= "Jack", Salary = 30000f},
        //        new Employee(){Id=30, Name= "Rose", Salary = 40000f}

        //    };
        //    return emps;
        //}


        ////Getting details through Query String: URL?varName=value; The sequence of these params can be changed
        //[HttpGet("Details")]
        //public string GetCustomerDetails(string accType, float amount)
        //{
        //    return $"Customer details with {accType} and balance greater than {amount} is returned";
        //}

        //[HttpGet]
        //[Route("EmailId")]
        //public string GetCustByEmail(string mail)
        //{
        //    return mail + " customer returned";
        //}

        ////Getting details through Route Variables

        //[HttpGet("Customer/{accType}/Balance/{amount}")]
        //public string GetCustomerByAccAndBalance(string accType, float amount)
        //{
        //    return $"Customer details with {accType} and balance greater than {amount} is returned";
        //}


        //[Route("Customers/{Id}")]
        //[HttpGet]
        //public string GetCustomerById(int Id)
        //{
        //    return $"Customer Details For Id = {Id} Are Returned";
        //}


        //[HttpGet("Accounts/{Type}")]
        //public string GetAccountByType(string Type)
        //{
        //    return $"Customer details with Type of account = {Type} are returned";
        //}

        //[HttpGet("Accounts")]
        //public List<string> GetAccountTypes()
        //{
        //    List<string> types = new List<string>() { "Saving", "Current", "Joint"};
        //    return types;
        //}

    }
}
