using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment_Models.Models
{
    [Table("Employees", Schema = "EfCore")]
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        [ForeignKey("Jobs")]
        [MaxLength(10)]
        [Required]
        public string JobId { get; set; }
        public Jobs Jobs { get; set; }

        public double Salary { get; set; }

        public double CommissionPct { get; set; }

        [ForeignKey("Managers")]
        public int ManagerId { get; set; }
        public Employees Managers { get; set; }

        [ForeignKey("Departments")]
        public int DepartmentId { get; set; }
        public Departments Departments { get; set; }

        public List<EmployeeProject> EmployeeProjects { get; set; }


    }
}
