using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Common;

namespace Persistence.Repositories
{
    public class ServiceRepository : AsyncRepository<Service>, IServiceRepository
    {
        public ServiceRepository(DbContext db)
            : base(db)
        {

        }
    }
}

