using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcLogin.Models;

    public class MvcAccountContext : DbContext
    {
        public MvcAccountContext (DbContextOptions<MvcAccountContext> options)
            : base(options)
        {
        }

        public DbSet<MvcLogin.Models.Account> Account { get; set; }
    }
