using System;
using System.Linq;
using FullstackPhoneBook.Domain.Contracts.People;
using FullstackPhoneBook.Domain.Core.People;
using FullstackPhoneBook.Infrastructures.Common;
using FullstackPhoneBook.Infrastructures.DataLayer.Common;

namespace FullstackPhoneBook.Infrastructures.DataAccess.People
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {

        public PersonRepository(PhoneBookContext dbContext) : base(dbContext)
        {

        }
    }
}
