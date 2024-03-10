using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcShoes.Models;
using System;
using System.Linq;

namespace MvcShoes
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcShoes.Data.ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcShoes.Data.ApplicationDbContext>>()))
            {
                // Check if the database already has data
                if (context.Product.Any())
                {
                    return; // Database has been seeded
                }

                context.Product.AddRange(
                    new Product { Id = 1, Name = "Nike", Price = 1999.99M, Description = "Innovative and high-quality athletic footwear, apparel, and accessories.", ImageUrl = "/images/img1.jfif", CustomerReview = 4.9 },
                    new Product { Id = 2, Name = " Adidas", Price = 1099.99M, Description = "A global brand offering sports shoes, clothing, and accessories with a focus on innovation and performance.", ImageUrl = "/images/img2.jfif", CustomerReview = 5.0 },
                    new Product { Id = 3, Name = " Puma", Price = 1200.99M, Description = "Known for its athletic and casual footwear, apparel, and accessories with a sleek and modern design", ImageUrl = "/images/img3.jfif", CustomerReview = 4.7 },
                    new Product { Id = 4, Name = " Reebok", Price = 179.99M, Description = "A brand providing athletic shoes, clothing", ImageUrl = "/images/img4.jfif", CustomerReview = 3.9 },
                    new Product { Id = 5, Name = "  New Balance", Price = 190.99M, Description = "Specializing in comfortable and supportive athletic shoes", ImageUrl = "/images/imh5.jpg", CustomerReview = 4.5 },
                    new Product { Id = 6, Name = " Under Armour", Price = 1129.99M, Description = "Performance-oriented brand offering sportswear", ImageUrl = "/images/img6.jpeg", CustomerReview = 4.7 },
                    new Product { Id = 7, Name = " Skerchers", Price = 305.99M, Description = "Known for stylish and comfortable casual and athletic shoes", ImageUrl = "/images/img7.webp", CustomerReview = 4.4 },
                    new Product { Id = 8, Name = " Vans", Price = 199.99M, Description = "A brand specializing in skateboard shoes, lifestyle footwear", ImageUrl = "/images/img.jfif", CustomerReview = 4.0 },
                    new Product { Id = 9, Name = "Converse", Price = 600.99M, Description = "Iconic brand famous for its classic canvas sneakers and casual footwear", ImageUrl = "/images/img9.jfig", CustomerReview = 4.1 },
                    new Product { Id = 10, Name = " Asics", Price = 100.99M, Description = "A Japanese brand known for its high-performance athletic shoes", ImageUrl = "/images/img10.jfif", CustomerReview = 2.2 }

                    // Add more product items here
                );

                context.SaveChanges();
            }
        }
    }
}
