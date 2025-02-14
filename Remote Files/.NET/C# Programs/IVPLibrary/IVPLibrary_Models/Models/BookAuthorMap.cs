using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVPLibrary_Models.Models
{
    public class BookAuthorMap
    {
        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        [ForeignKey("Books")]
        public int BookId { get; set; }

        //Navigation Property
        public Books Books { get; set; }
        public Author Author { get; set; }
    }
}
