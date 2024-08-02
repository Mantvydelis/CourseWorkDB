using SavarankiskaUzduotisPenktadienis.Contracts;
using SavarankiskaUzduotisPenktadienis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavarankiskaUzduotisPenktadienis.Services
{
    public class PostService : IPostRepository
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public void AddPost(Post post)
        {
            _postRepository.AddPost(post);
        }

        public void DeletePost(int postId)
        {
            _postRepository.DeletePost(postId);
        }

        public Post GetPost(int postId)
        {
            return _postRepository.GetPost(postId);
        }

    }
}
