using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Blog.Models;

namespace Blog.Mapping
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Articles");
            builder.HasKey(x => x.Id);
        }
    }
}
