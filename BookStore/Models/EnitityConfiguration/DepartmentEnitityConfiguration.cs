using BookStore.Models.Enitity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Models.EnitityConfiguration
{
    public class DepartmentEnitityConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department");
            builder.HasKey(x => x.DepartmentId);
            builder.Property(x=>x.ArabicName).HasMaxLength(50);
            builder.Property(x => x.EnglishName).HasMaxLength(50);
            builder.Property(x => x.Description).HasMaxLength(120);
            builder.HasIndex(x => x.ContactEmail).IsUnique();
            builder.HasIndex(x => x.PhoneNumber).IsUnique();
            builder.Property(x=>x.IsActive).HasDefaultValue(true);
        }
    }
}
