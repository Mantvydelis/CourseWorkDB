using SavarankiskaUzduotisPenktadienis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavarankiskaUzduotisPenktadienis.Contracts
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void DeleteUser(int userId);
        User GetUser(int userId);

    }
}
