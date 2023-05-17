using eArchive.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eArchive.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors_Researches>().HasKey(ar => new
            {
                ar.AuthorId,
                ar.ResearchId
            });

            modelBuilder.Entity<Authors_Researches>().HasOne(r => r.Research).WithMany(ar => ar.Authors_Researches).HasForeignKey(r => r.ResearchId);
            modelBuilder.Entity<Authors_Researches>().HasOne(r => r.Author).WithMany(ar => ar.Authors_Researches).HasForeignKey(r => r.AuthorId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Research> Researches { get; set; }
        public DbSet<Authors_Researches> Authors_Researches { get; set; }
    }
}
