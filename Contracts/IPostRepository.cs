using SavarankiskaUzduotisPenktadienis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavarankiskaUzduotisPenktadienis.Contracts
{
    public interface IPostRepository
    {
        void AddPost(Post post);
        void DeletePost(int postId);
        Post GetPost(int postId);

    }
}
