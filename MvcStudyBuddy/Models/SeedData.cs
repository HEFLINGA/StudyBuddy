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

            using (var context2 = new MvcStudyBuddy2Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcStudyBuddy2Context>>()))
            {
                // Look for any movies.
                if (context.Assignment.Any() && context2.Course.Any())
                {
                    return;   // DB has been seeded
                }

                context.Assignment.AddRange(
                    new Assignment
                    {
                        Title = "Homework 1",
                        Class = "CSCI135",
                        DueDate = DateTime.Parse("2021-2-12"),
                        Type = "Homework",
                        Points = 20,
                        Description = "First assignment"
                    },

                    new Assignment
                    {
                        Title = "Quiz 1",
                        Class = "CSCI225",
                        DueDate = DateTime.Parse("2021-3-12"),
                        Type = "Quiz",
                        Points = 50,
                        Description = "First quiz"
                    }
                );
                context.SaveChanges();
                context2.Course.AddRange(
                    new Course
                    {
                        Name = "CSCI225",
                        total_points = 500,
                        current_points = 0,
                        possible_points = 0,
                        Desc = "Intro to Relational Databases"
                    },

                    new Course
                    {
                        Name = "CSCI135",
                        total_points = 500,
                        current_points = 20,
                        possible_points = 20,
                        Desc = "Intro to Python"
                    }
                );
                context2.SaveChanges();
            }
        }
    }
}