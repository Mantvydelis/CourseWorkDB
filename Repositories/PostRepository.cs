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
    public class PostRepository : IPostRepository
    {

            private readonly IDbConnection _dbConnectionString;

            public PostRepository(string connectionString)
            {
                _dbConnectionString = new SqlConnection(connectionString);
            }

            public void AddPost(Post post)
            {
                var sql = "INSERT INTO Posts (UserId, Title, Content) VALUES (@UserId, @Title, @Content)";
                _dbConnectionString.Execute(sql, post);
            }

            public void DeletePost(int postId)
            {
                var sql = "DELETE FROM Posts WHERE Id = @Id";
                _dbConnectionString.Execute(sql, new { Id = postId });
            }

            public Post GetPost(int postId)
            {
                var sql = "SELECT * FROM Posts WHERE Id = @Id";
                return _dbConnectionString.QuerySingleOrDefault<Post>(sql, new { Id = postId });
            }
        }
    }

