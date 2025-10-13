using Social.Domain.Entities;
using Social.Domain.Interface;
using Social.Infrastructure.Presistance.Data;


namespace Social.Infrastructure.Presistance.Repository
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(ApplicationDBContext context):base(context)
        {
            
        }
    }
}
