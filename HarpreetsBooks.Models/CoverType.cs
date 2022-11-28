using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HarpreetsBooks.Models
{
    public class CoverType          // ADDED these new fields 
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "CoverType Name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
