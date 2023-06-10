using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApp.Models.Account;

public class RegisterModel
{
    [Required]
    [EmailAddress]
    [Remote(action: "IsEmailInUse", controller: "Account")]
    public string Email { get; set; }
    

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }


    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password")]
    [Compare("Password",
        ErrorMessage = "Password and Confirm Password do not match.")]
    public string ConfirmPassword { get; set; }
}