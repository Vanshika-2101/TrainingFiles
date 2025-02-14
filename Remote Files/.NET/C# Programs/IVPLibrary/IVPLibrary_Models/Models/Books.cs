using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //for Key allocation
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVPLibrary_Models.Models
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }

        [MaxLength(100)]
        [Required]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        [NotMapped]
        public decimal Discount { set { Discount = 0.1m; } }

        //[ForeignKey("BookDetails")] //Pass the navigation property here.
        //public int BookDetail_Id { get; set; }

        [ForeignKey("Publisher")]
        public int PUblisher_Id { get; set; }

        //Navigation Property
        public BookDetails BookDetails { get; set; }
        public Publisher Publisher { get; set; }

        public List<Author> Author { get; set; }

        public List<BookAuthorMap> BookAuthorMap { get; set; }
    }
}
