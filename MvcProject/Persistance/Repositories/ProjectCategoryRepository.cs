using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Common;

namespace Persistence.Repositories
{
    public class ProjectCategoryRepository : AsyncRepository<ProjectCategory>, IProjectCategoryRepository
    {
        public ProjectCategoryRepository(DbContext db)
            : base(db)
        {

        }
    }
}
