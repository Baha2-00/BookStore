﻿using BookStore.Models.Enitity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static BookStore.Helper.Enums.Enums;

namespace BookStore.Models.EnitityConfiguration
{
    public class PersonEnitityConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");
            builder.HasKey(t => t.PersonId);
            builder.Property(t=>t.PersonId).UseIdentityColumn();
            builder.Property(x => x.fullName).HasMaxLength(120);
            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.Phone).IsUnique();
            builder.ToTable(x => x.HasCheckConstraint("CH_Person_FullName", "FullName>=3"));
            builder.ToTable(x => x.HasCheckConstraint("CH_Person_Age", "Age>= 16"));
            builder.ToTable(x => x.HasCheckConstraint("CH_Person_Phone", "Phone LIKE '07________'"));
            builder.ToTable(x => x.HasCheckConstraint("CH_Person_Email", "EMAIL LIKE '%@______%.COM'"));
            builder.Property(x=>x.Gender).IsRequired();
            builder.Property(x=>x.IsActive).HasDefaultValue(true);

            builder.HasOne<Content>(x =>x.Content)
                .WithMany("Client").OnDelete(DeleteBehavior.Restrict); ;

        }
    }
}
