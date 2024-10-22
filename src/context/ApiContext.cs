using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using managers_back.src.managers;
using Microsoft.EntityFrameworkCore;

namespace managers_back.src.context
{
    public class ApiContext : DbContext
    {
        public DbSet<ManagerModel> Managers {get; set;}

        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Populate();
        }

    }
}