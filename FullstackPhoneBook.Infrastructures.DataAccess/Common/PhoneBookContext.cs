using Microsoft.EntityFrameworkCore;
using FullstackPhoneBook.Domain.Core.Tags;
using FullstackPhoneBook.Domain.Core.People;
using FullstackPhoneBook.Domain.Core.Phones;
using FullstackPhoneBook.Infrastructures.DataLayer.People;
using FullstackPhoneBook.Infrastructures.DataLayer.Tags;
using FullstackPhoneBook.Infrastructures.DataLayer.Phones;

namespace FullstackPhoneBook.Infrastructures.DataLayer.Common
{
    public class PhoneBookContext:DbContext
    {
        public DbSet<Tag>  Tags { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<PersonTag> PersonTags { get; set; }

        public DbSet<Phone> Phones { get; set; }

        public PhoneBookContext(DbContextOptions<PhoneBookContext> option) :base(option)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfig());
            modelBuilder.ApplyConfiguration(new PersonTagConfig());
            modelBuilder.ApplyConfiguration(new PhoneConfig());
            modelBuilder.ApplyConfiguration(new TagConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
