using Services.SkillGroup;
using Services.SkillType;

namespace CvResume.Models
{
    public class ResumeGetAllWiewModel
    {
        public IEnumerable<SkillTypeGetAll> SkillTypes { get; set; }
        public IEnumerable<SkillGroupGetAll> SkillGroups { get; set; }
    }
}
