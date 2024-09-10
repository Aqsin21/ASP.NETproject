using Domain.Entities;
using Repositories.Common;
using Repositories;
using Microsoft.EntityFrameworkCore;
namespace Persistance.Repositories
{
    internal class ContactPostRepository : AsyncRepository<ContactPost>, IContactPostRepository
    {
        public ContactPostRepository(DbContext db)
            : base(db)
        {

        }
    }
}
