using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FullstackPhoneBook.Domain.Core.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackPhoneBook.Infrastructures.DataLayer.People
{
    internal class PersonTagConfig : IEntityTypeConfiguration<PersonTag>
    {
        public void Configure(EntityTypeBuilder<PersonTag> builder)
        {

        }
    }
}
