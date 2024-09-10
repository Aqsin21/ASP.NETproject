using Domain.Entities;
using Repositories.Common;
using Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Repositories
{
    public class CategoryRepository : AsyncRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext db)
            : base(db)
        {

        }
    }
}
