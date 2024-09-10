using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Common;

namespace Persistence.Repositories
{
    public class SkillGroupRepository : AsyncRepository<SkillGroup>, ISkillGroupRepository
    {
        public SkillGroupRepository(DbContext db)
            : base(db)
        {

        }
    }
}

