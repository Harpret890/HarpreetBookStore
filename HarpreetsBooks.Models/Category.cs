using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HarpreetsBooks.Models
{
     public class Category          // ADDED these new fields 
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Category Name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
