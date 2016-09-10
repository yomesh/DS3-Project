using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EACUniformsDS3.Models
{
    public class Size
    {
        [Key]
        [Required]
        [Display(Name = "Size ID")]
        public int size_Id {get;set;}

        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        [Display(Name = "Size Description")]
        [Required]
        public string description {get;set;}

        [Required]
        [Display(Name = "Item Number")]
        public int item_Id { get; set; }

        [Required]
        [Display(Name = "Stock Quantity")]
        public int stock_qty { get; set; }
    }
}