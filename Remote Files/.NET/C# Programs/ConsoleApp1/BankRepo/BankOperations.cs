using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankProject.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Runtime.CompilerServices;

namespace BankProject.BankRepo
{
   
    internal class BankOperations : IBank
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        string str = "Server = 192.168.0.13\\sqlexpress,49753; Database = IVP3686; User Id = sa; Password= sa@12345678; TrustServerCertificate = True;";
        public async Task GetAllCustomers()
        {
            conn = new SqlConnection(str);
            cmd = new SqlCommand("USP_FETCHALL", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            cmd.Dispose();
            conn.Dispose();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine($"{row[0]} - {row[1]} - {row[2]} - {row[3]} - {row[4]}");
            }
        }

        public async Task GetCustomerByAccount(string ACCTYPE)
        {
            conn = new SqlConnection(str);
            cmd = new SqlCommand("USP_FETCH_ACCTYPE", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Type", ACCTYPE);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            cmd.Dispose();
            conn.Dispose();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine($"{row[0]} - {row[1]} - {row[2]} - {row[3]} - {row[4]}");
            }

        }

        public async Task<int> AddCustomer(Bank customer)
        {
            conn = new SqlConnection(str);
            await conn.OpenAsync();
            cmd = new SqlCommand("USP_INSERT", conn);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", customer.CID );
            cmd.Parameters.AddWithValue("@NAME", customer.CNAME);
            cmd.Parameters.AddWithValue("@TYPE", customer.ACCTYPE);
            cmd.Parameters.AddWithValue("@BAL", customer.BALANCE);
            cmd.Parameters.AddWithValue("@DATA", customer.COUNTRY);
            int a = await cmd.ExecuteNonQueryAsync();
            if(a > 0)
            {
                Console.WriteLine("Procedure executed successfully. Data Inserted.");
            }
            return a;
        }

        public async Task<int> UpdateCustomer(int ID, float BALANCE)
        {
            conn = new SqlConnection(str);
            await conn.OpenAsync();
            cmd = new SqlCommand("USP_UPDATE", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@BAL", BALANCE);
            int a = await cmd.ExecuteNonQueryAsync();
            if (a > 0)
            {
                Console.WriteLine("Procedure executed successfully. Data Updated.");
            }
            return a;

        }

        public async Task<int> DeleteCustomer(int ID)
        {
            conn = new SqlConnection(str);
            await conn.OpenAsync();
            cmd = new SqlCommand("USP_DELETE", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", ID);
            int a = await cmd.ExecuteNonQueryAsync();
            if (a > 0)
            {
                Console.WriteLine("Procedure executed successfully. Data Deleted.");
            }
            return a;
        }


    }
}
