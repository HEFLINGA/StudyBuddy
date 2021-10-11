using System;
using System.ComponentModel.DataAnnotations;

namespace MvcLogin.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}