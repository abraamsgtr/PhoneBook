using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FullstackPhoneBook.Domain.Core.Tags;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackPhoneBook.Infrastructures.DataLayer.Tags
{
    internal class TagConfig : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.Property(c => c.Title).HasMaxLength(50);
        }
    }
}
