// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.DependencyInjection;
// using MvcMovie.Data;
// using System;
// using System.Linq;

// namespace MvcMovie.Models;

// public static class SeedData
// {
//     public static void Initialize(IServiceProvider serviceProvider)
//     {
//         using (var context = new MvcBookContext(
//             serviceProvider.GetRequiredService<
//                 DbContextOptions<MvcBookContext>>()))
//         {
//             // Look for any CategoryType.
//             if (context.CategoryType.Any())
//             {
//                 return;   // DB has been seeded
//             }
//             context.Category.AddRange(
//                 new CategoryType
//                 {
//                     Id = 0,
//                     Type = "Physical",
//                     Name = "Physical books"                    
//                 },
//                 new CategoryType
//                 {
//                     Id = 1,
//                     Type = "Virtual",
//                     Name = "Virtual books"                    
//                 }
//             );

//             context.Category.AddRange(
//                 new Category
//                 {
//                     Id = 0,
//                     Type = 0,
//                     Description = "Romance books"                    
//                 },
//                 new Category
//                 {
//                     Id = 0,
//                     Type = 0,
//                     Description = "History books"                    
//                 },
//                 new Category
//                 {
//                     Id = 0,
//                     Type = 1,
//                     Description = "Digital School books"                    
//                 },
//                  new Category
//                 {
//                     Id = 0,
//                     Type = 1,
//                     Description = "Digital Travel books"                    
//                 }
//             );
//             context.SaveChanges();
//         }
//     }
// }