using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using BankProject.Models;

namespace BankProject.StudentRepo
{
    internal class StudentOperations : IStudent
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        string str = "Server = 192.168.0.13\\sqlexpress,49753; Database = IVP3686; User Id = sa; Password= sa@12345678; TrustServerCertificate = True;";

        public void GetAllStudents()
        {

        }

        public void GetStudentById(int id)
        {

        }

        public void AddStudent(Student student)
        {

        }
        public void UpdateStudent(int id, float marks)
        {

        }
        public void DeleteStudent(int id)
        {

        }

    }
}
