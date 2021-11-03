using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcStudyBuddy.Api.Models;

namespace MvcStudyBuddy.Api.Data
{
   public class MvcStudyBuddyContext : DbContext
    {
        public MvcStudyBuddyContext (DbContextOptions<MvcStudyBuddyContext> options)
            : base(options)
        {
        }

        public DbSet<MvcStudyBuddy.Api.Models.Assignment> Assignment { get; set; }

        public DbSet<MvcStudyBuddy.Api.Models.Todo> Todo { get; set; }
    } 
}
    
