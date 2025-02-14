using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    internal class AccountClass
    {
        public void GetDocuments()
        {
            Console.WriteLine("Received Documents");
        }
        public void VerifyDocuments()
        {
            Console.WriteLine("Documents Verified");
        }
        public void CreateSavingAccount()
        {
            Console.WriteLine("Saving Account Created");
        }
        public void DepositInitialBalance()
        {
            Console.WriteLine("Initial Balance 10000 Deposited");
        }
        public void CreateCurrentAccount()
        {
            Console.WriteLine("Current Account Created");
        }
        public void GiveDebitCard()
        {
            Console.WriteLine("Debit Card Given");
        }
    }
}
