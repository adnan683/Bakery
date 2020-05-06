using Bakery.Models;
using Microsoft.EntityFrameworkCore;
namespace Bakery.Data
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Döner Tasche",
                    Description = "Beschte Döner wo gibt",
                    Price = 8.99m,
                    ImageName = "doener.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Burger",
                    Description = "Ein kleiner Snack für zwischendurch",
                    Price = 9.99m,
                    ImageName = "burger.png"
                },
                new Product
                {
                    Id = 3,
                    Name = "Pide",
                    Description = "Die schöne alternative zur Pizza",
                    Price = 5.99m,
                    ImageName = "pide.jpg"
                },
                new Product
                {
                    Id = 4,
                    Name = "Kuzu Pirzola",
                    Description = "Lamm auf die beste Art und Weise",
                    Price = 1.49m,
                    ImageName = "kuzu.jpg"
                },
                new Product
                {
                    Id = 5,
                    Name = "Baklava",
                    Description = "Baklava geht immer",
                    Price = 5.99m,
                    ImageName = "baklava.jpg"
                },
                new Product
                {
                    Id = 6,
                    Name = "Künefe",
                    Description = "Wer es bis jetzt noch nicht probiert, dann wirds mal Zeit",
                    Price = 8.99m,
                    ImageName = "kunefa.jpg"
                }
            );
            return modelBuilder;
        }
    }
}