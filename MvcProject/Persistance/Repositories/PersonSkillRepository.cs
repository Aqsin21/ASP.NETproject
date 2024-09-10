using Domain.Entities;
using Repositories.Common;
using Repositories;
using Microsoft.EntityFrameworkCore;


namespace Persistance.Repositories
{
    public class PersonSkillRepository : AsyncRepository<PersonSkill>, IPersonSkillRepository
    {
        public PersonSkillRepository(DbContext db)
            : base(db)
        {

        }
    }
}
