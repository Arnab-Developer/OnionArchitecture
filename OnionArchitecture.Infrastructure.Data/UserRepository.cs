using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace OnionArchitecture.Infrastructure.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _userContext;

        public UserRepository(UserContext userContext)
        {
            _userContext = userContext;
        }

        IEnumerable<User> IUserRepository.GetAll()
        {
            List<User> users = _userContext.Users.ToList();
            return users;
        }

        void IUserRepository.Update(int userId, User user)
        {
            User userFromDb = _userContext.Users.FirstOrDefault(u => u.Id == userId);
            if (userFromDb == null) return;
            userFromDb.IsAdult = user.IsAdult;
            _userContext.SaveChanges();
        }
    }
}
