using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class MyBank
    {
            private double balance;
            public MyBank()
            { }
            public MyBank(double balance)
            {
                this.balance = balance;
            }
            public double Balance
            {
                get { return balance; }
            }
            public void Add(double amount)
            {
                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount));
                }
                balance += amount;
            }
            public void Withdraw(double amount)
            {
                if (amount > balance)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount));
                }
                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount));
                }
                balance -= amount;
            }
            public void TransferFundsTo(MyBank otherAccount, double
            amount)
            {
                if (otherAccount is null)
                {
                    throw new ArgumentNullException(nameof(otherAccount));
                }
                Withdraw(amount);
                otherAccount.Add(amount);
            }
    }
}
