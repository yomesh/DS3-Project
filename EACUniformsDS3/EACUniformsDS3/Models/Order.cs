using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EACUniformsDS3.Models
{
    public class Order
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
        [Display(Name = "Expected Delivery Date")]
        public DateTime ExpectedDeliveryDate { get; set; }

        [Required]
        //[DataType(DataType.Text)]
        [Display(Name = "User")]
        public string OrderedByUser { get; set; }

        [Required]
        [Display(Name = "Order Status")]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Status { get; set; }

        [Required]
        [Display(Name = "Order Total")]
        public double total { get; set; }
    }
}