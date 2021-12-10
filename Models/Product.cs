using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Finals.Models
{
    public class Product
    {
        public int ProductId {get; set;} //Primary key for product entity class

        [Display(Name = "Product Name")]
        [Required]
        public string ProductName {get; set;}

        [StringLength(30)]
        [Required]
        public string Genre {get; set;}

        [Range(1,100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price {get; set;}

        [StringLength(5)]
        [Required]
        public string Rating {get; set;}
        public List<Review> Reviews {get; set;} //Navigation property. One game can have many reviews

    }
}