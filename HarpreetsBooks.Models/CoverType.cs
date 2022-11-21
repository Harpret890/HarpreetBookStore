using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;        // added all the details similar to category.cs file 

namespace HarpreetsBooks.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "CoverType Name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
