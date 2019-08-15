using System;
using FullstackPhoneBook.Domain.Contracts.Common;
using FullstackPhoneBook.Domain.Core.Phones;

namespace FullstackPhoneBook.Domain.Contracts.Phones
{
    public interface IPhoneRepository : IBaseRepository<Phone>
    {
    }
}
