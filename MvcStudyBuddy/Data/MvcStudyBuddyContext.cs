using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcStudyBuddy.Models;

    public class MvcStudyBuddyContext : DbContext
    {
        public MvcStudyBuddyContext (DbContextOptions<MvcStudyBuddyContext> options)
            : base(options)
        {
        }

        public DbSet<MvcStudyBuddy.Models.Assignment> Assignment { get; set; }
    }
