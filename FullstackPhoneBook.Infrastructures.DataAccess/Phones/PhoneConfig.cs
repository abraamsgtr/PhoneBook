using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using FullstackPhoneBook.Domain.Core.Phones;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackPhoneBook.Infrastructures.DataLayer.Phones
{
    internal class PhoneConfig : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.Property(c => c.PhoneNumber).HasMaxLength(20).IsRequired();
        }
    }
}
