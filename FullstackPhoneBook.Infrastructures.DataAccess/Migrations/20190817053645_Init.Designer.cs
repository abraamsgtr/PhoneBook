﻿// <auto-generated />
using System;
using FullstackPhoneBook.Infrastructures.DataLayer.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FullstackPhoneBook.Infrastructures.DataAccess.Migrations
{
    [DbContext(typeof(PhoneBookContext))]
    [Migration("20190817053645_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FullstackPhoneBook.Domain.Core.People.Person", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(500);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Image")
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("FullstackPhoneBook.Domain.Core.People.PersonTag", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonId");

                    b.Property<int>("TagId");

                    b.HasKey("id");

                    b.HasIndex("PersonId");

                    b.HasIndex("TagId");

                    b.ToTable("PersonTags");
                });

            modelBuilder.Entity("FullstackPhoneBook.Domain.Core.Phones.Phone", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Personid");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("PhoneType");

                    b.HasKey("id");

                    b.HasIndex("Personid");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("FullstackPhoneBook.Domain.Core.Tags.Tag", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("FullstackPhoneBook.Domain.Core.People.PersonTag", b =>
                {
                    b.HasOne("FullstackPhoneBook.Domain.Core.People.Person", "Person")
                        .WithMany("Tags")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FullstackPhoneBook.Domain.Core.Tags.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FullstackPhoneBook.Domain.Core.Phones.Phone", b =>
                {
                    b.HasOne("FullstackPhoneBook.Domain.Core.People.Person")
                        .WithMany("Phones")
                        .HasForeignKey("Personid");
                });
#pragma warning restore 612, 618
        }
    }
}
