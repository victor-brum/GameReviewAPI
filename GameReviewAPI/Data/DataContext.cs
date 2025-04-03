using GameReviewAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GameReviewAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set;}
        public DbSet<Headquarters> Headquarters { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameCompany> gameCompanies { get; set; }
        public DbSet<GameCategory> GameCategories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameCategory>()
                .HasKey(gc => new { gc.GameId, gc.CategoryId });

            modelBuilder.Entity<GameCategory>()
                .HasOne(gc => gc.Game)
                .WithMany(g => g.GameCategories)
                .HasForeignKey(gc => gc.GameId);

            modelBuilder.Entity<GameCategory>()
                .HasOne(gc => gc.Category)
                .WithMany(c => c.GameCategories)
                .HasForeignKey(gc => gc.CategoryId);

            modelBuilder.Entity<GameCompany>()
                .HasKey(gp => new { gp.GameId, gp.CompanyId });

            modelBuilder.Entity<GameCompany>()
                .HasOne(gp => gp.Game)
                .WithMany(g => g.GameCompanies)
                .HasForeignKey(gp => gp.GameId);

            modelBuilder.Entity<GameCompany>()
                .HasOne(gp => gp.Company)
                .WithMany(p => p.GameCompanies)
                .HasForeignKey(gp => gp.CompanyId);
        }
    }
}
