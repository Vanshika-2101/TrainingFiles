﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVPLibrary_Models.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column("Name")]
        [Required]  //Not Null Annotation
        public string CategoryName { get; set; }

        //public string DisplayOrder {  get; set; }
    }
}
