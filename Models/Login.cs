using System.ComponentModel.DataAnnotations;

namespace ActivityCenter.Models
{
    public class Login
    {
        [Required]
        [Display (Name = "Login Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string LoginEmail { get; set; }

        [Required]
        [Display (Name = "Login Password")]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }
    }
}