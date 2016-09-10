using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace EACUniformsDS3.Models
{
    public class School
    {
        [Key]
        [Required]
        public int school_Id { get; set; }

        [Required]
        /*Specifies max length and min lenght that the field should be*/
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        /*Specifies the Name that should be displayed on the Interface*/
        [Display(Name = "School Name")]
        public string school_Name { get; set; }

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
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        /*Specifies the Name that should be displayed on the Interface*/
        [Display(Name = "City")]
        public string city { get; set; }

        [Required]
        [Range(1, 9999, ErrorMessage = "Please enter a number between 1 and 9999")]
        [Display(Name = "Postal Code")]
        public string postal_Code { get; set; }

       
        [Required]
        /*Specifies max length and min lenght that the field should be*/
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        /*Specifies the Name that should be displayed on the Interface*/
        [Display(Name = "Contact Person Name")]
        public string contact_Person { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = " Contact Person Email Address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Contact_eMail_Address { get; set; }

        [Required(ErrorMessage = "Your must provide a Contact Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        [Display(Name = "Contact Person Number")]
        public string contact_Number { get; set; }
    }
}