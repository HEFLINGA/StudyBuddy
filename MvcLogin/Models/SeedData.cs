using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using MvcLogin.Data;
using System;
using System.Linq;

namespace MvcLogin.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcAccountContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcAccountContext>>()))
            {
                // Look for any movies.
                if (context.Account.Any())
                {
                    return;   // DB has been seeded
                }

                context.Account.AddRange(
                    new Account
                    {
                        Name = "John Smith",
                        Dob = DateTime.Parse("2001-2-12"),
                        Email = "johnsmith@gmail.com",
                        Password = "password01"
                    },

                    new Account
                    {
                        Name = "Sally Harrison",
                        Dob = DateTime.Parse("2002-1-1"),
                        Email = "sharrison02@gmail.com",
                        Password = "password02"
                    },

                    new Account
                    {
                        Name = "Eric Rodding",
                        Dob = DateTime.Parse("1999-2-23"),
                        Email = "erod@mail.com",
                        Password = "password03"
                    },

                    new Account
                    {
                        Name = "Gentry Mellings",
                        Dob = DateTime.Parse("1998-4-13"),
                        Email = "got@mail.com",
                        Password = "password04"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}