using Microsoft.EntityFrameworkCore;
using Blog.Mapping;
using Blog.Models;

namespace Blog
{
    public class BlogContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
