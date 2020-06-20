using OnionArchitecture.Domain.Entities;
using System.Collections.Generic;

namespace OnionArchitecture.Domain.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        void Update(int userId, User user);
    }
}
