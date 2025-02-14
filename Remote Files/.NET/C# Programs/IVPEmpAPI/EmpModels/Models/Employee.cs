using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpModels.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        [Column("Employee_ID")]
        public int EID { get; set; }
        [Column("Employee_Name")]
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Designation { get; set; }
        [Required]
        public double Salary { get; set; }
        [NotMapped]
        public double Tax { get; set; }
    }
}
