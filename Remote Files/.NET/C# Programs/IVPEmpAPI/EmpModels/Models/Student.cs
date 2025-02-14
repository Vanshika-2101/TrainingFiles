using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpModels.Models
{
    public class Student
    {
        [Key] 
        public int SID { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }
    }
}
