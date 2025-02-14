using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankProject.Models;

namespace BankProject.StudentRepo
{
    internal interface IStudent
    {
        public void GetAllStudents();
        public void GetStudentById(int id);
        public void AddStudent(Student student);
        public void UpdateStudent(int id, float marks);
        public void DeleteStudent(int id);


    }
}
