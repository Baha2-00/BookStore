using BookStore.Models.Enitity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Models.EnitityConfiguration
{
    public class PersonEnitityConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            throw new NotImplementedException();
        }
    }
}
