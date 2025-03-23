using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using WebAPI.Data.Entities;

namespace WebAPI.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Visit>()
                .HasKey(v => new { v.CatId, v.VetId });

            builder.Entity<Visit>()
                .HasOne(v => v.Cat)
                .WithMany(c => c.Visits)
                .HasForeignKey(v => v.CatId);

            builder.Entity<Visit>()
                .HasOne(v => v.Vet)
                .WithMany(vet => vet.Visits)
                .HasForeignKey(v => v.VetId);

        }
        public DbSet<Cat> Cats { get; set; }
        public DbSet<WebAPI.Data.Entities.Vet> Vet { get; set; } = default!;
        public DbSet<WebAPI.Data.Entities.Visit> Visit { get; set; } = default!;
    }
}
