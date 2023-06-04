using Microsoft.EntityFrameworkCore;
using Web_first.EfStuff.DbModel;

namespace Web_first.EfStuff
{
    public class WebContext : DbContext
    {
        public DbSet<Image> Images { get; set; }
        public DbSet<ImageComment> Comments { get; set; }
        public WebContext (DbContextOptions options): base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>()
                .HasMany(images => images.Comments)
                .WithOne(comment => comment.Image);
        }

    }
}
