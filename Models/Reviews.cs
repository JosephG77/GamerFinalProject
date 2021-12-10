using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finals.Models
{
    public class Review
    {
        public int ReviewId {get; set;} //Primary key for review entity class

        [Range(1,5)]
        [Required]
        public int Score {get; set;}

        [Display(Name = "Product")]
        [Required]
        public int ProductId {get; set;} //Foreign key linking review to games and consoles
        public Product Product {get; set;} //Navigation property
    }
}