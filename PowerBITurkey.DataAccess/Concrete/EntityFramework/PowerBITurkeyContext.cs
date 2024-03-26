using Microsoft.EntityFrameworkCore;
using PowerBITurkey.Entities.Concrete;

namespace PowerBITurkey.DataAccess.Concrete.EntityFramework
{
    public class PowerBITurkeyContext : DbContext
    {
        public PowerBITurkeyContext(DbContextOptions<PowerBITurkeyContext> options) : base(options)
        {
        }
        public PowerBITurkeyContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonalInformation>().ToTable("PersonalInformations");
            modelBuilder.Entity<Blog>().ToTable("Blogs");
            modelBuilder.Entity<Blog>()
                .HasKey(b => b.BlogId);
            modelBuilder.Entity<PersonalInformation>()
                .HasKey(p=>p.AboutId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost; Database=PowerBITurkey; TrustServerCertificate=True;Trusted_Connection=True; Integrated Security=True");
            }
        }

        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}