using SavarankiskaUzduotisPenktadienis.Contracts;
using SavarankiskaUzduotisPenktadienis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavarankiskaUzduotisPenktadienis.Services
{
    public class UserService : IUserRepository
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(User user)
        {
            _userRepository.AddUser(user);
        }

        public void DeleteUser(int userId)
        {
            _userRepository.DeleteUser(userId);
        }

        public User GetUser(int userId)
        {
            return _userRepository.GetUser(userId);
        }
    }
}

  
