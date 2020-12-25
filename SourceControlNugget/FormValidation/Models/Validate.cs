using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FormValidation.Models
{
    public class Validate
    {
        [Required]
        [Display(Name = "Enter UserName")]
        [StringLength(maximumLength:15, MinimumLength =2, ErrorMessage = "UserName name must have Max length 15 and min length 3")]
        public string UserName { get; set; }
        
        [Required]
        [Display(Name ="Enter Age")]
        [Range(18,60,ErrorMessage ="Age between 18 and 60")]
        public string Age { get; set; }

        [Required]
        [Display(Name = "Enter Email")]
        [EmailAddress(ErrorMessage ="Enter valid Email Id")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Enter Password")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$",ErrorMessage = "Password must contain Minimum eight characters, at least one uppercase letter, one lowercase letter and one number")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Re Enter Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }

        [Required(ErrorMessage ="Gender is Required")]
        [Display(Name = "Enter Your Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Terms & Conditions")]
        [Range(typeof(bool),"true","true",ErrorMessage ="Accept The TnC!")]
        public bool TermsandConditions { get; set; }

    }
}