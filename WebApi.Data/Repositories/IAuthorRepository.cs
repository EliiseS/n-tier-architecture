using System.Threading.Tasks;
using WebApi.Domain.Models;

namespace WebApi.Data.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Task<Author> GetByName(string firstName);
    }
}