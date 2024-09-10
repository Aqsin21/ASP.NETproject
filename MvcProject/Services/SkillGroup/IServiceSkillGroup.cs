using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.SkillGroup
{
   public  interface IServiceSkillGroup
    {
        Task<IEnumerable<SkillGroupGetAll>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
