using Services.Services;
using Services.Skills;

namespace CvResume.Models
{
    public class HomeGetAllWiewModel
    {
        public IEnumerable<SkillGetAll> Skills { get; set; }
        public IEnumerable<ServiceGetAll> Services { get; set; }
    }
}
