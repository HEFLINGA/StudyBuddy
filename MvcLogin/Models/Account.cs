using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcLogin.Models
{
    public class Account
    {
        public int Id { get; set; }

        
        [Required]
        [StringLength(250, MinimumLength = 2)]
        public string Name { get; set; }
        
        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 3)]
        public string Email { get; set; }

        [Required]
        [StringLength(24, MinimumLength = 8)]
        public string Password { get; set; }
    }
}