using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcBook.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcBookContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcBookContext>>()))
        {
            // Look for any CategoryType.
            if (context.CategoryType.Any())
            {
                return;   // DB has been seeded
            }
            context.CategoryType.AddRange(
                new CategoryType
                {
                    Id = 1,
                    Type = "Physical",
                    Name = "Physical books"                    
                },
                new CategoryType
                {
                    Id = 2,
                    Type = "Digital",
                    Name = "Virtual books"                    
                }
            );

            // Look for any Category.
            if (context.Category.Any())
            {
                return;   // DB has been seeded
            }

            context.Category.AddRange(
                new Category
                {
                    Id = 5,
                    Type = 1,
                    Description = "Romance books"                    
                },
                new Category
                {
                    Id = 6,
                    Type = 1,
                    Description = "History books"                    
                },
                new Category
                {
                    Id = 7,
                    Type = 2,
                    Description = " School books"                    
                },
                 new Category
                {
                    Id = 8,
                    Type = 2,
                    Description = "Travel books"                    
                }
            );
            context.SaveChanges();
        }
    }
}