using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Domain.Interface
{
    public interface IUnitOfWork
    {
        //IMovieRepository Movies { get; }
        //IUserRepository Users { get; }
        IRepository<T> Repository<T>() where T : class;
        Task<int> CompleteAsync();
    }
}
