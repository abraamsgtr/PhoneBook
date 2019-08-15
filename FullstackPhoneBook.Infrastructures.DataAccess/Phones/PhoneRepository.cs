using System;
using System.Linq;
using FullstackPhoneBook.Domain.Contracts.Phones;
using FullstackPhoneBook.Domain.Core.Phones;
using FullstackPhoneBook.Infrastructures.Common;
using FullstackPhoneBook.Infrastructures.DataLayer.Common;

namespace FullstackPhoneBook.Infrastructures.DataAccess.Phones
{
    public class PhoneRepository : BaseRepository<Phone>, IPhoneRepository
    {
        public PhoneRepository(PhoneBookContext dbContext) : base(dbContext)
        {

        }
    }
}
