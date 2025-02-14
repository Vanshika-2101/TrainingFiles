using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment_Models.Models
{
    [Table("EmployeeProject", Schema = "EfCore")]
    public class EmployeeProject
    {
        [ForeignKey("Employees")]
        public int EmployeeId { get; set; }

        [ForeignKey("Projects")]
        public int ProjectId { get; set; }

        public Employees Employees { get; set; }
        public Projects Projects { get; set; }
    }
}
