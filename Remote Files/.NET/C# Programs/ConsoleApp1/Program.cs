using BankProject.BankRepo;
using BankProject.Controller;
using Microsoft.Identity.Client;

namespace BankProject
{
    internal class Program
    {
        public delegate void SBAccountDelegate();
        public delegate void CUAccountDelegate();
        public delegate void DebitCardDelegate();

        public static event SBAccountDelegate OpenSavingAccount;
        public static event CUAccountDelegate OpenCurrentAccount;
        public static event DebitCardDelegate ObtainDebitCard;

        public delegate void Calculate(int a);
        public static event Calculate CalculateEMI;
        static void Main(string[] args)
        {
            try
            {
                //int a = 10;
                //int b = 0;
                //int c = a / b;
                //Console.WriteLine(c);
                int[] arr = new int[5] { 1, 2, 3, 4, 5 };
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(arr[i]);
                }

            }
            catch (Exception e)
            {
                Logger.LogMessage(e.Message);
            }


            //Console.WriteLine("Events and Delegates");
            //Calc c = new Calc();
            //Calculate del = new Calculate(c.HomeLoanInterest);
            //del += new Calculate(c.CarLoanInterest);
            //del += new Calculate(c.StudyLoanInterest);
            //del += new Calculate(c.PersonalLoanInterest);
            //CalculateEMI = del;
            //CalculateEMI(2000);



            //AccountClass acc = new AccountClass();
            //DebitCardDelegate card = new DebitCardDelegate(acc.GiveDebitCard);
            ////card();

            //SBAccountDelegate sb = new SBAccountDelegate(acc.GetDocuments);
            //sb += new SBAccountDelegate(acc.VerifyDocuments);
            //sb += new SBAccountDelegate(acc.CreateSavingAccount);
            //sb += new SBAccountDelegate(acc.GiveDebitCard);
            ////sb.Invoke();
            //OpenSavingAccount = sb;
            //OpenSavingAccount.Invoke();

            //CUAccountDelegate cu = new CUAccountDelegate(acc.GetDocuments);
            //cu += new CUAccountDelegate(acc.VerifyDocuments);
            //cu += new CUAccountDelegate(acc.DepositInitialBalance);
            //cu += new CUAccountDelegate(acc.CreateCurrentAccount);
            //cu += new CUAccountDelegate(acc.GiveDebitCard);
            ////cu();
            //cu -= new CUAccountDelegate(acc.DepositInitialBalance);
            ////cu();
            //OpenCurrentAccount = cu;
            //OpenCurrentAccount();











            //Console.WriteLine("IVP Bank Project");
            //IBank ibank = new BankOperations();
            //BankController control = new BankController(ibank);
            //control.GetBankCustomers();
            //control.GetBankCustomersByAccount("Saving");
            //control.AddBankCutsomer(new Models.Bank() { CID = 100, CNAME = "Vanshika", ACCTYPE = "SAVING", BALANCE = 3455678f, COUNTRY = "UK" });
            //control.UpdateBankCustomer(100, 3456266f);
            //control.RemoveBankCutomer(200);


            Console.ReadKey();

        }
    }
}
