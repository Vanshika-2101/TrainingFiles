using System;
using System.Collections.Generic;
using System.Data; //dataSet 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient; //SqlDataAdapter

namespace ConsoleAppADO
{
    internal class ADODisconnectedClass
    {
        SqlDataAdapter da;
        DataSet ds;
        string connstr = "Server = 192.168.0.13\\sqlexpress,49753; Database = IVP3686; User ID=sa; Password=sa@12345678; TrustServerCertificate = true";
        string query1 = "Select * from Bank";
        string query2 = "Select * from Student";
        public void FetchData()
        {
            da = new SqlDataAdapter(query1,connstr);
            ds = new DataSet();
            da.Fill(ds, "Bank");

            foreach (DataRow row in ds.Tables["Bank"].Rows)
            {
                Console.WriteLine($"{row[0]} - {row[1]} - {row[2]} - {row[3]}");
            }

            SqlDataAdapter da1 = new SqlDataAdapter(query2,connstr);
            da1.Fill(ds, "Std");

            foreach(DataRow row in ds.Tables["Std"].Rows)
            {
                 Console.WriteLine($"{row[0]} - {row[1]} - {row[2]} - {row[3]}");
            }
        }

        string query3 = "Select * from bank; select * from student";
        public void FetchDataMultipleSelect()
        {
            da = new SqlDataAdapter(query3, connstr);
            ds = new DataSet();
            da.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine($"{row[0]} - {row[1]} - {row[2]} - {row[3]}");
            }

            SqlDataAdapter da1 = new SqlDataAdapter(query2, connstr);
            da1.Fill(ds, "Std");

            foreach (DataRow row in ds.Tables[1].Rows)
            {
                Console.WriteLine($"{row[0]} - {row[1]} - {row[2]} - {row[3]}");
            }
        }

    }
}
