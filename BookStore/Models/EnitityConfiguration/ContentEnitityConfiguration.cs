using BookStore.Models.Enitity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static BookStore.Helper.Enums.Enums;

namespace BookStore.Models.EnitityConfiguration
{
    public class ContentEnitityConfiguration : IEntityTypeConfiguration<Content>
    {
        public void Configure(EntityTypeBuilder<Content> builder)
        {
            builder.ToTable("Content");
            builder.HasKey(x => x.ContentId);
            builder.Property(x=>x.ContentId).UseIdentityColumn();
            builder.Property(x=>x.Name).HasMaxLength(40);
            builder.ToTable(x => x.HasCheckConstraint("CH_Content_Price", "Price>=4"));
            builder.ToTable(x => x.HasCheckConstraint("CH_Content_Description", "Description>=10"));
            builder.ToTable(x => x.HasCheckConstraint("CH_Content_Author", "Author>=5"));
            builder.Property(x => x.IsActive).HasDefaultValue(true);
        }
    }
}
