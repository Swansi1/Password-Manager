using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PassMan.Models;

namespace PassMan.Core.Utils
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<VaultEntry> VaultEntries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbContext"].ConnectionString;
            optionsBuilder.UseSqlite(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definiáljuk a kapcsolatot a User és VaultEntry között
            modelBuilder.Entity<VaultEntry>()
                .HasOne(ve => ve.User)
                .WithMany(u => u.VaultEntries)
                .HasForeignKey(ve => ve.UserId)
                .HasPrincipalKey(u => u.Username);

            base.OnModelCreating(modelBuilder);
        }
    }
}
