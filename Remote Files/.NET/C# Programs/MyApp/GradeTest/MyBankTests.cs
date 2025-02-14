using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp;

namespace GradeTest
{
    public class MyBankTests
    {
        MyBank _bank;

        [SetUp]
        public void Setup()
        {
            _bank = new MyBank(2000);
        }

        [TestCase(1000)]
        public void Adding_Funds_Updates_Balance(double amount)
        {
            _bank.Add(amount);
            Assert.AreEqual(3000, _bank.Balance);
        }

        [Test]
        public void Adding_Negative_Funds_Throws()
        {
            // Act + Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { _bank.Add(-100); });
        }

        [Test]
        public void Withdrawing_Funds_Updates_Balance()
        {
            _bank.Withdraw(500);
            Assert.AreEqual(1500, _bank.Balance);
        }

        [Test]
        public void Withdrawing_Negative_Funds_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { _bank.Withdraw(-100); });
        }

        [Test]
        public void Withdrawing_More_Than_Balance_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { _bank.Withdraw(5000); });
        }

        [Test]
        public void Transfering_Funds_Updates_Both_Accounts()
        {
            MyBank otherAcc = new MyBank(1000);
            _bank.TransferFundsTo(otherAcc, 2000);
            Assert.AreEqual(0, _bank.Balance);
            Assert.AreEqual(3000, otherAcc.Balance);
        }

        [Test]
        public void Transfer_To_Non_Existing_Account_Throws()
        {
            Assert.Throws<ArgumentNullException>(()=> _bank.TransferFundsTo(null, 200));
        }
    }
}
