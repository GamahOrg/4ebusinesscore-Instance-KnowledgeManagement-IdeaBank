namespace IdeaBank.Domain.Models
{
    public class IdeaLike : BaseEntity<Guid>
    {
        public Guid IdeaBankId { get; set; }
        public IdeaBank IdeaBank { get; set; }
        public LikeStatus LikeStatus { get; set; }
    }
}
