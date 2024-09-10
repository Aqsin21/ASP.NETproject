using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Common;

namespace Persistence.Repositories
{
    public class SkillRepository : AsyncRepository<Skill>, ISkillRepository
    {
        public SkillRepository(DbContext db)
            : base(db)
        {

        }
    }
}