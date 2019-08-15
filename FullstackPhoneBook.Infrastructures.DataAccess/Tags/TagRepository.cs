using System;
using System.Linq;
using FullstackPhoneBook.Domain.Contracts.Phones;
using FullstackPhoneBook.Domain.Contracts.Tags;
using FullstackPhoneBook.Domain.Core.Tags;
using FullstackPhoneBook.Infrastructures.Common;
using FullstackPhoneBook.Infrastructures.DataLayer.Common;

namespace FullstackPhoneBook.Infrastructures.DataAccess.Tags
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(PhoneBookContext dbContext) : base(dbContext)
        {

        }
    }
}
