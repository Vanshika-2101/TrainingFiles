using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment_Models.Models
{
    [Table("EmployeeDetails", Schema = "EfCore")]
    public class EmployeeDetails
    {
        [Key]
        public int EmployeeDetailsId { get; set; }

        public Employees Employees { get; set; }
        [ForeignKey("Employees")]
        public int EmployeeId { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        [MaxLength(12)]
        public string AadharNumber { get; set; }

    }
}
