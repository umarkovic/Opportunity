﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpportunITyy.Models
{
    public class Account
    {
        public string Description { get; set; }
        public string Location { get; set; }
        [Required (ErrorMessage = "This field is required")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required (ErrorMessage = "This field is required")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
