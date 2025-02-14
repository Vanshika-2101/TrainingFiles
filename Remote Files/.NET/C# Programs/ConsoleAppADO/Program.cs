

namespace ConsoleAppADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            ADOConnectedClass cc = new ADOConnectedClass();
            //cc.InsertData();
            //cc.DeleteData();
            //cc.UpdateData();
            //cc.FetchData();
            //cc.FetchDataAccType("Saving");
            //cc.FetchDataMultipleRes();

            ADODisconnectedClass cc2 = new ADODisconnectedClass();
            //cc2.FetchDataMultipleSelect();
            //cc2.FetchData();

            SPClass sc = new SPClass();
            //sc.SPInsert();
            //sc.SPDelete();
            //sc.SPUpdate();
            //sc.SPFetchAll();
            //sc.SPFetchAcc();

            BulkInsertClass bi = new BulkInsertClass();
            bi.BulkOperation();
        }
    }
}
