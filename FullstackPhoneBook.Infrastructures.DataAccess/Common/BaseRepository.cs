using FullstackPhoneBook.Domain.Contracts;
using FullstackPhoneBook.Domain.Contracts.Common;
using FullstackPhoneBook.Domain.Core;
using FullstackPhoneBook.Infrastructures.DataLayer.Common;
using System.Linq;


namespace FullstackPhoneBook.Infrastructures.Common
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity :BaseEntity,new()
    {
        private readonly PhoneBookContext dbContext;

        public BaseRepository(PhoneBookContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public TEntity Add(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
            dbContext.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            TEntity entity = new TEntity
            {
                id = id
            };
            dbContext.Remove(entity);
            dbContext.SaveChanges();
        }

        public TEntity Get(int id)
        {
            return dbContext.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return dbContext.Set<TEntity>().AsQueryable();
        }
    }
}
