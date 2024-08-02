using SavarankiskaUzduotisPenktadienis.Contracts;
using SavarankiskaUzduotisPenktadienis.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace SavarankiskaUzduotisPenktadienis.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnection _dbConnectionString;

        public UserRepository(string connectionString)
        {
            _dbConnectionString = new SqlConnection(connectionString);
        }

        public void AddUser(User user)
        {
            var sql = "INSERT INTO Users (Name, Email) VALUES (@Name, @Email)";
            _dbConnectionString.Execute(sql, user);
        }

        public void DeleteUser(int userId)
        {
            var sql = "DELETE FROM Users WHERE Id = @Id";
            _dbConnectionString.Execute(sql, new { Id = userId });
        }

        public User GetUser(int userId)
        {
            var sql = "SELECT * FROM Users WHERE Id = @Id";
            return _dbConnectionString.QuerySingleOrDefault<User>(sql, new { Id = userId });
        }
    }

    
}
