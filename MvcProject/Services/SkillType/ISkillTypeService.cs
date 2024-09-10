using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.SkillType
{
    public interface ISkillTypeService
    {
        Task<IEnumerable<SkillTypeGetAll>> GetAllAsync(CancellationToken cancellationToken = default);

    }
}
