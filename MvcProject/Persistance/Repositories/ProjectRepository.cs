using Domain.Entities;
using Repositories.Common;
using Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Repositories
{
    public class ProjectRepository : AsyncRepository<Project>, IProjectRepository
    {
        public ProjectRepository(DbContext db)
            : base(db)
        {

        }
    }
}
