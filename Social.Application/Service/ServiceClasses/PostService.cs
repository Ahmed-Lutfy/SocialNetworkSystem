using Social.Application.Service.Interface;
using Social.Domain.Entities;
using Social.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Application.Service.ServiceClasses
{
    public class PostService : IPostService
    {
        public IUnitOfWork _unitOfWork;
        public PostService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Post> createPost(Post post)
        {
            return await _unitOfWork.Repository<Post>().AddAsync(post);
        }

        public async Task<IEnumerable<Post>> GetPosts()
        {
            return await _unitOfWork.Repository<Post>().GetAllAsync();
        }
    }
}
