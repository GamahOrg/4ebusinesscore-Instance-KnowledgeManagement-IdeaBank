namespace IdeaBank.Domain.Models
{
    public class IdeaRate : BaseEntity<Guid>
    {
        public Guid IdeaBankId { get; set; }
        public IdeaBank IdeaBank { get; set; }
        public int RateValue { get; set; }
    }
}
