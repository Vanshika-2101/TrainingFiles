using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment_Models.Models
{
    [Table("Departments", Schema ="EfCore")]
    public class Departments
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        [MaxLength(30)]
        public string DepartmentName { get; set; }

        [ForeignKey("Managers")]
        public int ManagerId { get; set; }
        public Employees Managers { get; set; }
    }
}
