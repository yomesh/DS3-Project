using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace EACUniformsDS3.Models
{
    public class OrdItem
    {
        [Key]
        [Required]
        public int OrderId { get; set; }

      
        [Required]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

      
        [Required]
        //[DataType(DataType.Text)]
        [Display(Name = "Supplier")]
        public string Supplier { get; set; }

        [Required]
        [Display(Name = "Item Number")]
        public int item_Id { get; set; }

        [Required]
        [Display(Name = "Order Quantity")]
        [Range(1, 9999, ErrorMessage = "Please enter a number between 1 and 9999")]
        public int Quantity { get; set; }

        
        [Display(Name = "Received Quantity")]
        [Range(0, 9999, ErrorMessage = "Please enter a number between 0 and 9999")]
        public int RecQuantity { get; set; }

        [Required]
        [Display(Name = "Unit Price")]
        [Range(0.1, 9999, ErrorMessage = "Please enter a number between 1c and R9999.99")]
        public decimal UnitPrice { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        [Display(Name = "Item Description")]
        public string description { get; set; }

        [Required]
        [Display(Name = "Total")]
        public double total { get; set; }

        [Required]
        [Display(Name = "Vat")]
        public int vat { get; set; }

    }
}