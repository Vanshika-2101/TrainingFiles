using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    internal class Calc
    {
        public void HomeLoanInterest(int a)
        {
            Console.WriteLine("Monthly EMI for Home Loan = " + (a * 0.1));
        }

        public void CarLoanInterest(int a)
        {
            Console.WriteLine("Monthly EMI for Car Loan= " + (a * 0.15));
        }

        public void StudyLoanInterest(int a)
        {
            Console.WriteLine("Monthly EMI for Study Loan = " + (a * 0.06));
        }

        public void PersonalLoanInterest(int a)
        {
            Console.WriteLine("Monthly EMI for Personal Loan = " + (a * 0.20));
        }
    }
}
