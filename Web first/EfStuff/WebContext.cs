using Microsoft.EntityFrameworkCore;
using Web_first.EfStuff.DbModel;

namespace Web_first.EfStuff
{
    public class WebContext : DbContext
    {
        public DbSet<Image> Images { get; set; }
        public WebContext (DbContextOptions options): base(options)
        {

        }


    }
}
