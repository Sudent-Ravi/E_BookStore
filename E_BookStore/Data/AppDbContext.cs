using E_BookStore.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace E_BookStore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }
        public DbSet<Category> CategoryTB { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data for Category table

            modelBuilder.Entity<Category>().HasData(
                new Category { Id =1 , Name = "Math" , DisplayOrder = 1 },
                new Category { Id =2 , Name = "Hindi" , DisplayOrder = 2 },
                new Category { Id =3 , Name = "English" , DisplayOrder = 3 },
                new Category { Id =4 , Name = "History" , DisplayOrder = 4 }
                );
        }
    }
}
