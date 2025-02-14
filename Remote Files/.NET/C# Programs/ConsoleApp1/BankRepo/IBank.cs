using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankProject.Models;

namespace BankProject.BankRepo
{
    internal interface IBank
    {
        public Task GetAllCustomers();
        public Task GetCustomerByAccount(string ACCTYPE);
        public Task<int> AddCustomer(Bank customer);
        public Task<int> UpdateCustomer(int ID, float BALANCE);
        public Task<int> DeleteCustomer(int ID);
    }
}
