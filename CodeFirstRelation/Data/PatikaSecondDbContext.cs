using CodeFirstRelation.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelation.Data
{
    public class PatikaSecondDbContext : DbContext
    {
        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=200309;Database=dbname");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasOne(p => p.User) // Her postun yalnızca bir sahibi vardır.
            .WithMany(a => a.Posts) // Userların birden fazla postu olabilir.
            .HasForeignKey(p => p.UserId); // Postların sahini UserId ile belirleniyor.
        }
    }
}
