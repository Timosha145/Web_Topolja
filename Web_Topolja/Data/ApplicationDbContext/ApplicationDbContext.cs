using Microsoft.EntityFrameworkCore;
using Web_Topolja.Models;

namespace Web_Topolja.Data.ApplicationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<ContactData> ContactDatas { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
