using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MoodMeApp.Models
{
    public class Signup
    {
        [Key]
        public int UserID { get; set; }

        [Required (ErrorMessage = "This field is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Please confirm password.")]
        [DataType(DataType.Password)]
        public string PasswordConfirmation { get; set; }
    }
}
