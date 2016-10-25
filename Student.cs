using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MKCWebApplication.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide First Name")]
        [MaxLength(50)]
        [DisplayName("Name")]
        public string FirstName { get; set; }
        
        [MaxLength(50)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage="Please provide Gender")]
        [MaxLength(6)]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        [Phone(ErrorMessage="Not a valid phone number")]
        public string Phone { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Dob { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }
    }
}