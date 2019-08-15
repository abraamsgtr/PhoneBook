using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FullstackPhoneBook.Infrastructures.DataLayer.Common
{
    public class PhoneBookContextFactory : IDesignTimeDbContextFactory<PhoneBookContext>
    {
  
        public PhoneBookContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PhoneBookContext>();
            builder.UseSqlServer("Server=127.0.0.1; Database=PhoneBookDb;" +
                "User ID=sa;Password=reallyStrongPwd123;MultipleActiveResultSets=true");

            return new PhoneBookContext(builder.Options);
        }    
    }
}
