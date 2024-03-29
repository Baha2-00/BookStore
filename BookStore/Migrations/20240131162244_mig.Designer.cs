﻿// <auto-generated />
using System;
using BookStore.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStore.Migrations
{
    [DbContext(typeof(BookStoreDBContext))]
    [Migration("20240131162244_mig")]
    partial class mig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookStore.Models.Enitity.Content", b =>
                {
                    b.Property<int>("ContentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContentId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContentType")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePublished")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("subscriptionId")
                        .HasColumnType("int");

                    b.HasKey("ContentId");

                    b.HasIndex("subscriptionId");

                    b.ToTable("Content", null, t =>
                        {
                            t.HasCheckConstraint("CH_Content_Author", "Author>=5");

                            t.HasCheckConstraint("CH_Content_Description", "Description>=10");

                            t.HasCheckConstraint("CH_Content_Price", "Price>=4");
                        });
                });

            modelBuilder.Entity("BookStore.Models.Enitity.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<int>("ArabicName")
                        .HasColumnType("int");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<int>("EnglishName")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DepartmentId");

                    b.HasIndex("ContactEmail")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("Department", (string)null);
                });

            modelBuilder.Entity("BookStore.Models.Enitity.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("ContentId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("birthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("fullName")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<int>("personType")
                        .HasColumnType("int");

                    b.Property<int>("subscriptionId")
                        .HasColumnType("int");

                    b.HasKey("PersonId");

                    b.HasIndex("ContentId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Phone")
                        .IsUnique();

                    b.HasIndex("subscriptionId");

                    b.ToTable("Person", null, t =>
                        {
                            t.HasCheckConstraint("CH_Person_Age", "Age>= 16");

                            t.HasCheckConstraint("CH_Person_Email", "EMAIL LIKE '%@______%.COM'");

                            t.HasCheckConstraint("CH_Person_FullName", "FullName>=3");

                            t.HasCheckConstraint("CH_Person_Phone", "Phone LIKE '07________'");
                        });
                });

            modelBuilder.Entity("BookStore.Models.Enitity.Subscription", b =>
                {
                    b.Property<int>("subscriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("subscriptionId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DownloadedBookAmount")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("SubscriptionType")
                        .HasColumnType("int");

                    b.Property<float>("durationInDays")
                        .HasColumnType("real");

                    b.HasKey("subscriptionId");

                    b.ToTable("Subscription", null, t =>
                        {
                            t.HasCheckConstraint("CH_Subscription_Description", "Description>= 8");

                            t.HasCheckConstraint("CH_Subscription_DownloadedBookAmount", "DownloadedBookAmount>=4");

                            t.HasCheckConstraint("CH_Subscription_Price", "Price>=10");

                            t.HasCheckConstraint("CH_Subscription_durationInDays", "durationInDays >=15");
                        });
                });

            modelBuilder.Entity("BookStore.Models.Enitity.Content", b =>
                {
                    b.HasOne("BookStore.Models.Enitity.Subscription", "Subscription")
                        .WithMany("Contents")
                        .HasForeignKey("subscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("BookStore.Models.Enitity.Person", b =>
                {
                    b.HasOne("BookStore.Models.Enitity.Content", "Content")
                        .WithMany("Client")
                        .HasForeignKey("ContentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BookStore.Models.Enitity.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Models.Enitity.Subscription", "Subscrip")
                        .WithMany("Client")
                        .HasForeignKey("subscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Content");

                    b.Navigation("Department");

                    b.Navigation("Subscrip");
                });

            modelBuilder.Entity("BookStore.Models.Enitity.Content", b =>
                {
                    b.Navigation("Client");
                });

            modelBuilder.Entity("BookStore.Models.Enitity.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("BookStore.Models.Enitity.Subscription", b =>
                {
                    b.Navigation("Client");

                    b.Navigation("Contents");
                });
#pragma warning restore 612, 618
        }
    }
}
