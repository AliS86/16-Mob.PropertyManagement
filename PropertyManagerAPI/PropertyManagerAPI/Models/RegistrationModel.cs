﻿using System.ComponentModel.DataAnnotations;

namespace PropertyManagerAPI.Models
{
    public class RegistrationModel
    {
        //making email address required
        [Required]
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}