using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Infrastructure.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
