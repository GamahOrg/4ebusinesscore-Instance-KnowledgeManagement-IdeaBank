

namespace IdeaBank.Domain.Models
{
    public class LK_IdeaCategory : BaseEntity<int>
    {
        public string NameAr {  get; set; } 
        public string NameEn {  get; set; } 
        public bool IsSeed {  get; set; } 
    }
}
