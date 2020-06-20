using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Domain.Interfaces;
using OnionArchitecture.Services.Interfaces;
using System.Collections.Generic;

namespace OnionArchitecture.Services.ApplicationServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        void IUserService.ProcessUsers()
        {
            IEnumerable<User> users = _userRepository.GetAll();
            foreach (User user in users)
            {
                user.DetermineAdult();
                _userRepository.Update(user.Id, user);
            }
        }
    }
}
