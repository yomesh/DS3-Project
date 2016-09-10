using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EACUniformsDS3.Models
{
    public class Item
    {
        [Key]
        [Required]
        [Display(Name = "Item Number")]
        public int item_Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [Display(Name = "Item Description")]
        public string description { get; set; }

        [Required]
        [Range(0.1, 9999, ErrorMessage = "Please enter a number between 1c and R9999.99")]
        [Display(Name = "Item Cost Price in 'ZAR'")]
        public decimal Cprice { get; set; }

        [Required]
        [Range(0.1, 9999, ErrorMessage = "Please enter a number between 1c and R9999.99")]
        [Display(Name = "Item Sell Price in 'ZAR'")]
        public decimal Sprice { get; set; }

        [Required]
        [Display(Name = "Item Supplier")]
        public string supplier { get; set; }

        [Display(Name = "Image")]
        public string imageUrl { get; set; }

        [Required]
        /*Specifies max length and min lenght that the field should be*/
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        /*Specifies the Name that should be displayed on the Interface*/
        [Display(Name = "School Name")]
        public string school_Name { get; set; }

    }
}