using Social.Domain.Entities;
using Social.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Application.Service.Interface
{
    public interface IPostService
    {
        Task<Post> createPost(Post post);
        Task<IEnumerable<Post>> GetPosts();
    }
}
