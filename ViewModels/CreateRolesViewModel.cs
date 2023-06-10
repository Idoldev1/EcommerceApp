using System;
using System.ComponentModel.DataAnnotations;

namespace EcommerceApp.ViewModels;

public class CreateRolesViewModel
{
    [Required]
    public string RoleName { get; set; }
}