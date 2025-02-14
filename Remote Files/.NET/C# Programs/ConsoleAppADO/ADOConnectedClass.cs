using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppADO
{
    internal class ADOConnectedClass
    {
        string connstr = "Server = 192.168.0.13\\sqlexpress,49753; Database = IVP3686; User ID=sa; Password=sa@12345678; TrustServerCertificate = true";
        string connstr1 = "Data Source = 192.168.0.13\\sqlexpress,49753; Initial Catalog = IVP3686; User ID=sa; Password=sa@12345678; TrustServerCertificate = true";
        string query1 = "INSERT INTO BANK (CID, CNAME, ACCTYPE, BALANCE, COUNTRY) VALUES (100, 'KHUMAR', 'SAVING', 736789, 'USA')";

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        public void InsertData()
        {
            try
            {
                conn = new SqlConnection(connstr);
                conn.Open();
                cmd = new SqlCommand(query1, conn);
                int a = cmd.ExecuteNonQuery();
                Console.WriteLine(a + " Record Inserted Sucessfully.");
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (cmd != null) { cmd.Dispose(); }
                if (conn != null) { conn.Close(); }
            }
        }
        public void DeleteData()
        {
            try
            {
                Console.WriteLine("Give an Id");
                int Id = int.Parse(Console.ReadLine());
                string query2 = "DELETE FROM BANK WHERE CID = " + Id;
                conn = new SqlConnection(connstr1);
                conn.Open();
                cmd = new SqlCommand(query2, conn);
                int a = cmd.ExecuteNonQuery();
                Console.WriteLine(a + " Record Deleted Sucessfully.");
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (cmd != null) { cmd.Dispose(); }
                if (conn != null) { conn.Close(); }
            }
        }

        string query3 = "UPDATE BANK SET BALANCE = 999999 WHERE CID = 10";
        public void UpdateData()
        {
            try
            {
                conn = new SqlConnection(connstr1);
                conn.Open();
                cmd = new SqlCommand(query3, conn);
                int a = cmd.ExecuteNonQuery();
                Console.WriteLine(a + " Record Updated Sucessfully.");
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (cmd != null) { cmd.Dispose(); }
                if (conn != null) { conn.Close(); }
            }
        }

        public void FetchData()
        {
            try
            {
                conn = new SqlConnection(connstr1);
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM BANK", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine($"{dr[0]} - {dr["CName"]} - {dr[2]} - {dr["Balance"]} - {dr[4]}");
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (cmd != null) { cmd.Dispose(); }
                if (conn != null) { conn.Close(); }
            }
        }
        public void FetchDataAccType(string accType)
        {
            try
            {
                conn = new SqlConnection(connstr1);
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM BANK WHERE ACCTYPE = '" + accType + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine($"{dr[0]} - {dr["CName"]} - {dr[2]} - {dr["Balance"]} - {dr[4]}");
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (cmd != null) { cmd.Dispose(); }
                if (conn != null) { conn.Close(); }
            }
            
        }

        public void FetchDataMultipleRes()
        {

            try
            {
                conn = new SqlConnection(connstr1);
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM BANK; SELECT * FROM dbo.STUDENT", conn);
                dr = cmd.ExecuteReader();
                Console.WriteLine("First Result Set:");
                while (dr.Read())
                {
                    Console.WriteLine($"{dr[0]} - {dr["CName"]} - {dr[2]} - {dr["Balance"]} - {dr[4]}");
                }
                Console.WriteLine("Second Result Set: ");
                while (dr.NextResult())
                {
                    while (dr.Read())
                    {
                        Console.WriteLine($"{dr[0]} - {dr[1]} - {dr[2]} - {dr[3]}");
                    }
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (cmd != null) { cmd.Dispose(); }
                if (conn != null) { conn.Close(); }
            }
        }


    }
}
