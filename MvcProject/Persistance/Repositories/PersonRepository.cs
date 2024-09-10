using Domain.Entities;
using Repositories.Common;
using Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Repositories
{
    public class PersonRepository : AsyncRepository<Person>, IPersonRepository
    {
        public PersonRepository(DbContext db)
            : base(db)
        {

        }
    }
}
