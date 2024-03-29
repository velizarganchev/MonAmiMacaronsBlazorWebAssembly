﻿using System.ComponentModel.DataAnnotations;

namespace MonAmiMacaronsBlazorWebAssembly.Shared
{
    public class UserRegister
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, StringLength(100,MinimumLength = 6, ErrorMessage = "The password must be between 6 and 100 symbols.")]
        public string Password { get; set; } = string.Empty;

        [Compare("Password", ErrorMessage = "The passwords do not match.")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
