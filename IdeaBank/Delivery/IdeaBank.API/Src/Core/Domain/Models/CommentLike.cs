namespace IdeaBank.Domain.Models
{
    public class CommentLike : BaseEntity<Guid>
    {
        public Guid IdeaCommentId { get; set; }
        public IdeaComment IdeaComment { get; set; }
        public LikeStatus LikeStatus { get; set; }
    }
}
