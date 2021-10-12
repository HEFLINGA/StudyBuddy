using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcStudyBuddy.Data;
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
                // Look for assignments
                if (context.Assignment.Any())
                {
                    return;   // Seeded the data base
                }

                context.Assignment.AddRange(
                    new Assignment
                    {
                        Name = "Homework 1",
                        Description = "A description for homework 1",
                        DueDate = DateTime.Today
                    },

                    new Assignment
                    {
                        Name = "Homework 2",
                        Description = "A description for homework 2",
                        DueDate = DateTime.Today
                    }
                );
                context.SaveChanges();
            }
        }
    }
}