using System;
using System.Linq;
using FullstackPhoneBook.Domain.Contracts.People;
using FullstackPhoneBook.Domain.Core.People;
using FullstackPhoneBook.Domain.Core.Tags;
using FullstackPhoneBook.Infrastructures.Common;
using FullstackPhoneBook.Infrastructures.DataLayer.Common;

namespace FullstackPhoneBook.Infrastructures.DataAccess.People
{
    public class PersonTagRepository : BaseRepository<PersonTag>, IPersonTagRepository
    {

        public PersonTagRepository(PhoneBookContext dbContext) : base(dbContext)
        {

        }
    }
}
