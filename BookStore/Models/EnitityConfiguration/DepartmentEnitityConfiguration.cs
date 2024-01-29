using BookStore.Models.Enitity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Models.EnitityConfiguration
{
    public class DepartmentEnitityConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            throw new NotImplementedException();
        }
    }
}
