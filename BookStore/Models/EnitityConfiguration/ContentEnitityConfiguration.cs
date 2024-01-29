using BookStore.Models.Enitity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Models.EnitityConfiguration
{
    public class ContentEnitityConfiguration : IEntityTypeConfiguration<Content>
    {
        public void Configure(EntityTypeBuilder<Content> builder)
        {
            throw new NotImplementedException();
        }
    }
}
