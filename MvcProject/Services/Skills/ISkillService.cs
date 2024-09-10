using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Skills
{
    public  interface ISkillService
    {
        Task<IEnumerable<SkillGetAll>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
