using System;
using EcommerceApp.Data;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApp.Models;

public static class SeedData
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Goods>().HasData(
            new Goods
            {
                Id = 1,
                Name = "Leather Jacket",
                Description = "Nice men's Leather Jacket for outing", 
                ProfilePicture = "~/wwwroot/images/jacket.jfif",
                Price = 7500 ,
                Quantity = 7,
                Category = Category.Men
            },

            new Goods
            {
                Id = 2,
                Name = "Fashion Heels",
                Description = "Nice heels for outing", 
                ProfilePicture = "~/wwwroot/images/heels.jfif",
                Price = 8500,
                Quantity = 5,
                Category = Category.Women
            },

            new Goods
            {
                Id = 3,
                Name = "Electric Mouse",
                Description = "Keeps your Cat busy all day", 
                ProfilePicture = "~/wwwroot/images/emouse.jfif",
                Price = 3000,
                Quantity = 0,
                Category = Category.Pets
            },

            new Goods
            {
                Id = 4,
                Name = "Combat Joggers",
                Description = "High quality cargo pant for kids", 
                ProfilePicture = "~/C:/Users/Hp/Downloads/joggers.jfif",
                Price = 9000,
                Quantity = 16,
                Category = Category.Kids
            },

            new Goods
            {
                Id = 5,
                Name = "Hublot Wristwatch",
                Description = "Exclusive waterproof watch for all", 
                ProfilePicture = "~/wwwroot/images/hublot.jfif",
                Price = 23600,
                Quantity = 6,
                Category = Category.General
            },

            new Goods
            {
                Id = 6,
                Name = "Mini Gown",
                Description = "Sexy short gown ladies", 
                ProfilePicture = "~/wwwroot/images/gown.jfif",
                Price = 5500,
                Quantity = 0,
                Category = Category.Ladies
            } 
        );
    }
}