using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment_Models.Models
{
    [Table("Projects", Schema ="EfCore")]
    public class Projects
    {
        [Key]
        public int ProjectId { get; set; }
        [Required]
        [MaxLength(50)]
        public string ProjectName { get; set; }

        public List<EmployeeProject> EmployeeProjects { get; set; }
    }
}
