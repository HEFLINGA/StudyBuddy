using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcStudyBuddy.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcStudyBuddyContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcStudyBuddyContext>>()))
            {
                // Look for any movies.
                if (context.Assignment.Any())
                {
                    return;   // DB has been seeded
                }

                context.Assignment.AddRange(
                    new Assignment
                    {
                        Title = "Homework 1",
                        DueDate = DateTime.Parse("2021-2-12"),
                        Type = "Homework",
                        Points = 20,
                        Description = "First assignment"
                    },

                    new Assignment
                    {
                        Title = "Quiz 1",
                        DueDate = DateTime.Parse("2021-3-12"),
                        Type = "Quiz",
                        Points = 50,
                        Description = "First quiz"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}