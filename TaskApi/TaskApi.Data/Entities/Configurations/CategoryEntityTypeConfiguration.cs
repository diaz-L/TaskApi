using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskApi.Data.Entities.Configurations
{
    public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "work"
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "home"
                },
                new Category
                {
                    CategoryId = 3,
                    Name = "entertainment"
                },
                new Category
                {
                    CategoryId = 4,
                    Name = "Miscellaneous"
                });
        }
    }
}