using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Service_Center_IS.Database
{
    public class User
    {
        [Required]
        [MinLength(6)]
        public string Name { get; set; }
        [Required]
        [MinLength(6)]
        public string Surname { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Birthday date")]
        [MinLength(6)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public string DateOfBirthday { get; set; }
        [Required(ErrorMessage = "Telephone Number Required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [MinLength(6)]
        public string Email { get; set; }
    }
}