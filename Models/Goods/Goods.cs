using System;
using System.ComponentModel.DataAnnotations;
using EcommerceApp.Data;

namespace EcommerceApp.Models;

public class Goods
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50, MinimumLength =4, ErrorMessage ="Name must be between 4 and 50 characters")]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    [Display(Name = "Profile Picture")]
    public string ProfilePicture { get; set; }

     public int Quantity { get; set; }

    [Required]
    public double Price { get; set; }

    [Required]
    public Category Category { get; set; }
}