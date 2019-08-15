using System;
using FullstackPhoneBook.Domain.Contracts.Common;
using FullstackPhoneBook.Domain.Core.People;

namespace FullstackPhoneBook.Domain.Contracts.People
{
    public interface IPersonRepository : IBaseRepository<Person>
    {

    }
}
