using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankProject.BankRepo;
using BankProject.Models;

namespace BankProject.Controller
{
    internal class BankController
    {
        IBank _bank;

        public BankController(IBank bank)
        {
            _bank = bank;
        }   
            
        public async Task GetBankCustomers()
        {   
            await _bank.GetAllCustomers();
        }

        public async Task GetBankCustomersByAccount(string type)
        {
            await _bank.GetCustomerByAccount(type);
        }

        public async Task AddBankCutsomer(Bank cutsomer)
        {
            Console.WriteLine(await _bank.AddCustomer(cutsomer)+ " Record Inserted.");
        }

        public async Task RemoveBankCutomer(int id)
        {
            Console.WriteLine(await _bank.DeleteCustomer(id) + " Record Deleted.");
        }

        public async Task UpdateBankCustomer(int id, float bal)
        {
            Console.WriteLine(await _bank.UpdateCustomer(id, bal) + " Record Updated.");
        }

    }
}
