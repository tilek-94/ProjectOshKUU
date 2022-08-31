using Microsoft.EntityFrameworkCore;
using OshKUU.Models;

namespace ProjectOshKUU.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Audience> Audience { get; set; }
        public AppDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=BasaForApp.db");
        }
    }
}
