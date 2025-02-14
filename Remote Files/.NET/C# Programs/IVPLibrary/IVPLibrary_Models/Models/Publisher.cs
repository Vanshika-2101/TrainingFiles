using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVPLibrary_Models.Models
{
    [Table("Publishers")]
    public class Publisher
    {
        [Key]
        public int PUblisher_Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Location { get; set; }
    }
}
