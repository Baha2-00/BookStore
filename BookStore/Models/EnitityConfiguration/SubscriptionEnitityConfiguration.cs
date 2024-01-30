using BookStore.Models.Enitity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Models.EnitityConfiguration
{
    public class SubscriptionEnitityConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.ToTable("Subscription");
            builder.HasKey(x=>x.subscriptionId);
            builder.Property(x=>x.Name).HasMaxLength(50);
            builder.ToTable(x => x.HasCheckConstraint("CH_Subscription_Price", "Price>=10"));
            builder.ToTable(x => x.HasCheckConstraint("CH_Subscription_Description", "Description>= 8"));
            builder.ToTable(x => x.HasCheckConstraint("CH_Subscription_durationInDays", "durationInDays >=15"));
            builder.ToTable(x => x.HasCheckConstraint("CH_Subscription_DownloadedBookAmount", "DownloadedBookAmount>=4"));
            builder.Property(x=>x.IsActive).HasDefaultValue(true);
        }
    }
}
