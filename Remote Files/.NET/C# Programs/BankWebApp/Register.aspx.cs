using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace BankWebApp
{
    public partial class Register : System.Web.UI.Page
    {
        string str;

        public Register()
        {
            this.str = ConfigurationManager.ConnectionStrings["IVPBank"].ConnectionString.ToString();
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string str = ConfigurationManager.ConnectionStrings["IVPBank"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand("USP_INSERT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", int.Parse(TextBox1.Text));
            cmd.Parameters.AddWithValue("@NAME", TextBox2.Text);
            cmd.Parameters.AddWithValue("@TYPE", DropDownList1.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@BAL", float.Parse(TextBox3.Text));
            cmd.Parameters.AddWithValue("@DATA", TextBox4.Text);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                Label6.Text = "Record Inserted Succefully.";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //string str = ConfigurationManager.ConnectionStrings["IVPBank"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand("USP_UPDATE", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", int.Parse(TextBox1.Text));
            cmd.Parameters.AddWithValue("@BAL", float.Parse(TextBox3.Text));
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                Label6.Text = "Record Updated Successfully";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //string str = ConfigurationManager.ConnectionStrings["IVPBank"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand("USP_FETCHALL", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            Label6.Text = "Following are the entries from Bank Table.";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //string str = ConfigurationManager.ConnectionStrings["IVPBank"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand("USP_DELETE", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@ID", int.Parse(TextBox1.Text));
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                Label6.Text = "Record Deleted Successfully.";
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //string str = ConfigurationManager.ConnectionStrings["IVPBank"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand("USP_FETCH_ACCTYPE", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Type", DropDownList1.SelectedItem.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            Label6.Text =($"Following are the entries from Bank Table for ID = {DropDownList1.SelectedItem.Text}.");
        }
    }
}