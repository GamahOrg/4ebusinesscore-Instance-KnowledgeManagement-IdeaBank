namespace IdeaBank.Domain.Models
{
    public class IdeaView : BaseEntity<Guid>
    {
        public Guid IdeaBankId { get; set; }
        public IdeaBank IdeaBank { get; set; }
    }
}
