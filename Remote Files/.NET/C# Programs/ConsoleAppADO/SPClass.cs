using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ConsoleAppADO
{
    internal class SPClass
    {
        SqlDataReader dr;
        SqlDataAdapter da;
        SqlConnection conn;
        SqlCommand cmd;
        DataSet ds;

        string connstr = "Server = 192.168.0.13\\sqlexpress,49753; Database = IVP3686; User ID=sa; Password=sa@12345678; TrustServerCertificate = true";
        public void SPInsert()
        {
            conn = new SqlConnection(connstr);
            conn.Open();
            cmd = new SqlCommand("USP_INSERT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID",200);
            cmd.Parameters.AddWithValue("@NAME", "Rohan");
            cmd.Parameters.AddWithValue("@TYPE", "Joint");
            cmd.Parameters.AddWithValue("@BAL", 2000000f);
            cmd.Parameters.AddWithValue("@DATA", "India");
            int a = cmd.ExecuteNonQuery();
            Console.WriteLine("Procedure executed");
            conn.Close();
            cmd.Dispose();
            conn.Dispose();
        }

        public void SPDelete()
        {
            conn = new SqlConnection(connstr);
            conn.Open();
            cmd = new SqlCommand("USP_DELETE", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", 200);
            int a = cmd.ExecuteNonQuery();
            Console.WriteLine("Procedure executed");
            conn.Close();
            cmd.Dispose();
            conn.Dispose();
        }

        public void SPUpdate()
        {
            try
            {
                conn = new SqlConnection(connstr);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "USP_UPDATE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", 100);
                cmd.Parameters.AddWithValue("@BAL", 1234000f);
                int a = cmd.ExecuteNonQuery();
                Console.WriteLine("Procedure executed");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Dispose();
            }
        }

        public void SPFetchAll()
        {
            try
            {
                conn = new SqlConnection(connstr);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "USP_FETCHALL";
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                conn.Close();
                cmd.Dispose();
                conn.Dispose();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Console.WriteLine($"{dr[0]} \t {dr[1]} \t {dr[2]} \t {dr[3]}");
                }

                Console.WriteLine("Procedure executed");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                da.Dispose(); 
                ds.Clear(); 
                ds.Dispose();
            }
        }

        public void SPFetchAcc()
        {
            try
            {
                conn = new SqlConnection(connstr);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "USP_FETCH_ACCTYPE";
                cmd.Parameters.AddWithValue("@TYPE", "Joint");
                cmd.CommandType = CommandType.StoredProcedure;
                //da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                //da.Fill(ds);

                SqlDataReader dreader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dreader);
                ds.Tables.Add(dt);

                conn.Close();
                cmd.Dispose();
                conn.Dispose();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Console.WriteLine($"{dr[0]} \t {dr[1]} \t {dr[2]} \t {dr[3]}");
                }

                Console.WriteLine("Procedure executed");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (da != null) da.Dispose();
                ds.Clear();
                ds.Dispose();
            }
        }
    }
}
