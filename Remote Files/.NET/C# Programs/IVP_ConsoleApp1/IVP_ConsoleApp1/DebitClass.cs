using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    public abstract class DebitCard
    {
        public void IssueDebitCard()
        {
            Console.WriteLine("Debit Card Issued");
        }

        public abstract void IssueCreditCard();
    }

    public class HDFCSavingAccount : DebitCard
    {
        public override void IssueCreditCard()
        {
            Console.WriteLine("Credit Card issued in the name of Account holder");
        }
    }

    public class HDFCCurrentAccount : DebitCard
    {
        public override void IssueCreditCard()
        {
            Console.WriteLine("Credit Card issued in the name of Company");
        }
    }

    public class HDFCChildAccount : DebitCard
    {
        public override void IssueCreditCard()
        {
            //Console.WriteLine("Credit Card issued in the name of Parent");
        }
    }
}