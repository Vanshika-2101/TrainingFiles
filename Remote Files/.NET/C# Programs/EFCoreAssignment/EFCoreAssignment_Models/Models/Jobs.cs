using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAssignment_Models.Models
{
    [Table("Jobs", Schema = "EfCore")]
    public class Jobs
    {
        [Key]
        [MaxLength(10)]
        public string JobId { get; set; }
        [Required]
        [MaxLength(50)]
        public string JobTitle { get; set; }

        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
    }
}


