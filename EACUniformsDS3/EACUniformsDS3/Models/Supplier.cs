using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace EACUniformsDS3.Models
{
    public class Supplier
    {
        [Key]
        [Required]
        public int supplier_Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        [Display(Name = "Supplier Name")]
        public string supplier_Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Supplier Email Address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email_Address { get; set; }

        [Required(ErrorMessage = "Your must provide a Contact Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        [Display(Name = "Contact Number")]
        public string contact_Number { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
        [Display(Name = "Contact Surname")]
        public string ContactSurname { get; set; }

        [Required]
        /*Specifies max length and min lenght that the field should be*/
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        /*Specifies the Name that should be displayed on the Interface*/
        [Display(Name = "Address Line 1")]
        public string address_Line1 { get; set; }

        [Required]
        /*Specifies max length and min lenght that the field should be*/
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        /*Specifies the Name that should be displayed on the Interface*/
        [Display(Name = "Address Line 2")]
        public string address_Line2 { get; set; }

        [Required]
        /*Specifies max length and min lenght that the field should be*/
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        /*Specifies the Name that should be displayed on the Interface*/
        [Display(Name = "Suburb")]
        public string suburb { get; set; }

        [Required]
        /*Specifies max length and min lenght that the field should be*/
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        /*Specifies the Name that should be displayed on the Interface*/
        [Display(Name = "City")]
        public string city { get; set; }

        [Required]
        [Range(1, 9999, ErrorMessage = "Please enter a number between 1 and 9999")]
        [Display(Name = "Postal Code")]
        public string postal_Code { get; set; }

        [Required]
        [Range(1, 31, ErrorMessage = "Please enter number of Days 1 - 31")]
        [Display(Name = "Lead Time")]
        public int Lead_Time { get; set; }
    }
}