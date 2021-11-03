using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcStudyBuddy.Models;

    public class MvcStudyBuddy2Context : DbContext
    {
        public MvcStudyBuddy2Context (DbContextOptions<MvcStudyBuddy2Context> options)
            : base(options)
        {
        }

        public DbSet<MvcStudyBuddy.Models.Course> Course { get; set; }
    }
