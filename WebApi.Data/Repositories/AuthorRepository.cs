using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi.Domain.Models;

namespace WebApi.Data.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(DatabaseContext context) : base(context) { }

        public Task<Author> GetByName(string name)
        {
            return context.Set<Author>().FirstOrDefaultAsync(author => author.Name == name);
            // return FirstOrDefault(author => author.Name == name);
        }
    }
}