using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVPLibrary_Models.Models
{
    public class BookDetails
    {
        [Key]
        public int BookDetail_Id { get; set; }

        [Required]
        public int NumberOfChapters { get; set; }

        public int NumberOfPages { get; set; }

        public string Weight { get; set; } 

        //Navigation Property
        public Books Books { get; set; }

        [ForeignKey("Books")]
        public int BookId { get; set; }

    }
}
