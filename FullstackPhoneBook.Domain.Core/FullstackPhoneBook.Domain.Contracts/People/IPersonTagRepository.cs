using System;
using FullstackPhoneBook.Domain.Contracts.Common;
using FullstackPhoneBook.Domain.Core.People;
using FullstackPhoneBook.Domain.Core.Tags;

namespace FullstackPhoneBook.Domain.Contracts.People
{
    public interface IPersonTagRepository : IBaseRepository<PersonTag>
    {
    }
}
