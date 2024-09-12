using Services.Services;
using Services.Skills;

namespace CvResume.Models
{
    public class HomeGetAllWiewModel
    {
        public required IEnumerable<SkillGetAll> Skills { get; set; }
        public required IEnumerable<ServiceGetAll> Services { get; set; }
    }
}
